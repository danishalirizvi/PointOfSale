using Dapper;
using PointOfSale.Data.Entities;
using PointOfSale.Data.Enum;
using PointOfSale.Data.Params;
using PointOfSale.Data.ReportViews;
using PointOfSale.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;


namespace PointOfSale.Data.DataAccess
{
    public class InvoiceDao
    {
        private string _connectionstring = string.Empty;

        public InvoiceDao(string connectionString)
        {
            _connectionstring = connectionString;
        }


        public List<ReportVM> GetInvoicesByParametter(ReportParams param)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                List<ReportVM> data = new List<ReportVM>();
                var output = con.Query<ReportVM>(@"SELECT * from AllSalesReportView");
                if (output?.ToList().Count > 0)
                {
                    data = new List<ReportVM>();
                    foreach (var item in output.ToList())
                    {
                        DateTime invoiceDate;
                        DateTime.TryParse(item.Date, out invoiceDate);
                        if ((DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) <= DateTime.Parse(param.ToDate.ToString("yyyy-MM-dd"))) &&
                            (DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) >= DateTime.Parse(param.FromDate.ToString("yyyy-MM-dd"))))

                        {
                            data.Add(item);
                        }
                    }
                }
                //var output = con.Query<ReportVM>(@"SELECT * from AllSalesReportView where
                //        strftime('%d-%m-%Y %H:%M:%S', InvoiceDate)>=@FromDate
                //        and strftime('%d-%m-%Y %H:%M:%S', InvoiceDate)<=@ToDate",
                //        new { FromDate = param.FromDate, ToDate = param.ToDate });
                return data.ToList();
            }
        }

        public Invoice GetInvoiceWithItemsByID(object invoiceID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<Invoice>("SELECT * FROM INVOICE WHERE (InvoiceID = @InvoiceID)", new { InvoiceID = invoiceID });

                if (output != null && output.InvoiceID > 0)
                {

                    var invoiceItems = con.Query<InvoiceItem>("SELECT * FROM  InvoiceItem WHERE(InvoiceID = @InvoiceID)", new { InvoiceID = output.InvoiceID });
                    if (invoiceItems != null && invoiceItems.Any())
                    {
                        output.Items = invoiceItems.ToList();
                    }

                    var invoiceCustomer = con.QueryFirstOrDefault<InvoiceCustomer>("SELECT * FROM  InvoiceCustomer WHERE(InvoiceID = @InvoiceID)", new { InvoiceID = output.InvoiceID });
                    if (invoiceCustomer != null && invoiceCustomer.CustomerID > 0)
                    {
                        output.invcCustomer = invoiceCustomer;
                    }
                    return output;
                }
            }

            return null;
        }

        public void CancelInvoice(int refId)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Query("UPDATE INVOICE SET InvoiceStatus = @InvoiceStatus where InvoiceID = @InvoiceID",
                           new { InvoiceStatus = InvoiceStatusEnum.Cancelled.ToString(), InvoiceID = refId });

                UpdateStockForCancelledInvoice(refId, con);
            }

        }

        public string GetLastRunningNumber(string invoiceType)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<RunningNumber>("select LastRuningNumber from RunningNumber WHERE InvoiceType = @InvoiceType",
                           new { InvoiceType = invoiceType });

                return (output != null && output.Any()) ? output.FirstOrDefault().LastRuningNumber : null;
            }
        }

        public string GetMaxRunningNumberAssigned(string invoiceType)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<RunningNumber>("select max(InvoiceNumber) MaxRunningNumber from Invoice where InvoiceType = @InvoiceType",
                           new { InvoiceType = invoiceType });

                return (output != null && output.Any()) ? output.FirstOrDefault().MaxRunningNumber : null;
            }
        }

        public List<SupplierReportVM> getSupplierInvoices()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<SupplierReportVM>(@"SELECT * from AllSupplierPayments");
                return output.ToList();
            }
        }

        public List<Invoice> GetInvoices()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Invoice>("SELECT * FROM INVOICE", new DynamicParameters());
                List<Invoice> invoices = output.ToList();
                return invoices;
            }
        }

        public List<Invoice> GetInvoicesWithItems()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Invoice>("SELECT * FROM INVOICE", new DynamicParameters());
                List<Invoice> invoices = output.ToList();
                if (invoices != null && invoices.Any())
                {
                    foreach (var invoice in invoices)
                    {
                        var invoiceItems = con.Query<InvoiceItem>("SELECT * FROM  InvoiceItem WHERE(InvoiceID = @InvoiceID)", new { InvoiceID = invoice.InvoiceID });
                        if (invoiceItems != null && invoiceItems.Any())
                        {
                            invoice.Items = invoiceItems.ToList();
                        }
                    }
                    return invoices;
                }
            }

            return null;
        }



        public void SaveInvoice(Invoice invc)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO Invoice (InvoiceDate, InvoiceNumber, InvoiceType, IsActive, Comment, TotalToPay, PaymentMethodID, ReferenceInvoiceNumber, ReferenceInvoiceID, InvoiceStatus)
                                VALUES (@InvoiceDate, @InvoiceNumber, @InvoiceType, 1, @Comment, @TotalToPay, @PaymentMethodID,@ReferenceInvoiceNumber,@ReferenceInvoiceID, @InvoiceStatus); SELECT CAST(last_insert_rowid() as int)";
                int id = con.QuerySingle<int>(query, new
                {
                    InvoiceDate = invc.InvoiceDate,
                    InvoiceNumber = invc.InvoiceNumber,
                    InvoiceType = invc.InvoiceType,
                    PaymentMethodID = invc.PaymentMethodID,
                    Comment = invc.Comment,
                    TotalToPay = invc.TotalToPay,
                    ReferenceInvoiceID = invc.ReferenceInvoiceID,
                    ReferenceInvoiceNumber = invc.ReferenceInvoiceNumber,
                    InvoiceStatus = invc.InvoiceStatus
                });

                invc.Items.ToList().ForEach(t => { t.InvoiceID = id; });

                string childQuery = @"Insert into InvoiceItem (InvoiceID, ProductID, Quantity, UnitPrice, IsActive, UnitType, TotalPrice, SupplierID, SalePrice, ProductName, ProductCode, ProductRawPrice) 
                    VALUES (@InvoiceID, @ProductID, @Quantity, @UnitPrice, @IsActive, @UnitType, @TotalPrice, @SupplierID, @SalePrice, @ProductName, @ProductCode, @ProductRawPrice)";
                con.Execute(childQuery, invc.Items);

                if (invc.InvoiceType == InvoiceTypeEnum.SaleInvoice.ToString())
                {
                    if (invc.invcCustomer != null)
                    {
                        string invceCustQuery = @"INSERT INTO InvoiceCustomer(InvoiceID, CustomerID, TotalAmount, SalesTax, Discount, ReceivedAmount, ChangeAmount, DueAmount, DiscountPercentage, DiscountPercentageAmount, FixedDiscount, SalesPersonID)
                                                VALUES (@InvoiceID, @CustomerID, @TotalAmount, @SalesTax, @Discount, @ReceivedAmount, @ChangeAmount, @DueAmount, @DiscountPercentage, @DiscountPercentageAmount, @FixedDiscount, @SalesPersonID)";
                        con.Query(invceCustQuery, new
                        {
                            InvoiceID = id,
                            CustomerID = invc.invcCustomer.CustomerID,
                            TotalAmount = invc.invcCustomer.TotalAmount,
                            SalesTax = invc.invcCustomer.SalesTax,
                            Discount = invc.invcCustomer.Discount,
                            ReceivedAmount = invc.invcCustomer.ReceivedAmount,
                            ChangeAmount = invc.invcCustomer.ChangeAmount,
                            DueAmount = invc.invcCustomer.DueAmount,
                            DiscountPercentage = invc.invcCustomer.DiscountPercentage,
                            DiscountPercentageAmount = invc.invcCustomer.DiscountPercentageAmount,
                            FixedDiscount = invc.invcCustomer.FixedDiscount,
                            SalesPersonID = invc.invcCustomer.SalesPersonID
                        });
                    }

                    updateCustomerDueAmpunt(invc, con);
                    UpdateItemsStockForInvoice(id, con);
                    UpdateRunningNumber(invc.InvoiceType, invc.InvoiceNumber);

                }
                else if (invc.InvoiceType == InvoiceTypeEnum.PurchaseInvoice.ToString())
                {
                    UpdateItemsStockForPurchaseInvoice(id, con);
                    UpdateRunningNumber(invc.InvoiceType, invc.InvoiceNumber);
                }
            }
        }

        private void UpdateRunningNumber(string invoiceType, string invoiceNumber)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string invcNum = GetLastRunningNumber(invoiceType);
                if (invcNum == null)
                {
                    string query = @"INSERT INTO RunningNumber (LastRuningNumber, invoiceType)
                                VALUES (@LastRuningNumber, @invoiceType); SELECT CAST(last_insert_rowid() as int)";
                    int id = con.QuerySingle<int>(query, new
                    {
                        LastRuningNumber = invoiceNumber,
                        invoiceType = invoiceType
                    });
                }
                else
                {

                    UpdateInvoiceRunningNumber(invoiceType, invoiceNumber);
                }
            }
        }

        public void UpdateInvoiceRunningNumber(string invoiceType, string updateRunningNumber)
        {
            try
            {
                using (IDbConnection con = new SQLiteConnection(_connectionstring))
                {
                    con.Query("UPDATE RunningNumber SET [LastRuningNumber] = @LastRuningNumber WHERE invoiceType = @invoiceType",
                      new { LastRuningNumber = updateRunningNumber, invoiceType = invoiceType });
                }
            }
            catch (Exception)
            {
            }
        }

        private void updateCustomerDueAmpunt(Invoice invc, IDbConnection con)
        {
            if (invc.invcCustomer.DueAmount > 0)
            {
                try
                {
                    con.Query("UPDATE Customer SET [DueAmount] = [DueAmount] + @DueAmount WHERE CustomerID=@CustomerID",
                    new { DueAmount = invc.invcCustomer.DueAmount, CustomerID = invc.invcCustomer.CustomerID });
                }
                catch (Exception ex)
                {

                }
            }
        }

        public List<ReportVM> GetInvoicesByItem(ReportParams param)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                List<ReportVM> data = new List<ReportVM>();
                var output = con.Query<ReportVM>(@"SELECT * from SalesByItemReportView");
                if (output?.ToList().Count > 0)
                {
                    data = new List<ReportVM>();
                    foreach (var item in output.ToList())
                    {
                        DateTime invoiceDate;
                        DateTime.TryParse(item.Date, out invoiceDate);
                        if (param.ProductID != 0)
                        {
                            if ((DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) <= DateTime.Parse(param.ToDate.ToString("yyyy-MM-dd"))) &&
                            (DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) >= DateTime.Parse(param.FromDate.ToString("yyyy-MM-dd"))) &&
                             item.ProductID == param.ProductID
                            )

                            {
                                data.Add(item);
                            }
                        }
                        else
                        {
                            if ((DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) <= DateTime.Parse(param.ToDate.ToString("yyyy-MM-dd"))) &&
                            (DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) >= DateTime.Parse(param.FromDate.ToString("yyyy-MM-dd")))
                            )

                            {
                                data.Add(item);
                            }
                        }
                    }

                }

                return data;
            }
        }

        public List<ReportVM> GetInvoicesByCutomer(ReportParams param)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                List<ReportVM> data = new List<ReportVM>();
                var output = con.Query<ReportVM>(@"SELECT * from SalesByCustomerReportView");
                if (output?.ToList().Count > 0)
                {
                    data = new List<ReportVM>();
                    foreach (var item in output.ToList())
                    {
                        DateTime invoiceDate;
                        DateTime.TryParse(item.Date, out invoiceDate);
                        if (param.CustomerID != 0)
                        {
                            if ((DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) <= DateTime.Parse(param.ToDate.ToString("yyyy-MM-dd"))) &&
                            (DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) >= DateTime.Parse(param.FromDate.ToString("yyyy-MM-dd"))) &&
                             item.CustomerID == param.CustomerID
                            )
                            {
                                data.Add(item);
                            }
                        }
                        else
                        {
                            if ((DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) <= DateTime.Parse(param.ToDate.ToString("yyyy-MM-dd"))) &&
                            (DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) >= DateTime.Parse(param.FromDate.ToString("yyyy-MM-dd"))))
                            {
                                data.Add(item);
                            }
                        }
                    }

                }

                return data;
            }
            //using (IDbConnection con = new SQLiteConnection(_connectionstring))
            //{

            //    var output = con.Query<ReportVM>(@"SELECT * from SalesByCustomerReportView where
            //            strftime('%d-%m-%Y %H:%M:%S', InvoiceDate)>=@FromDate
            //            and strftime('%d-%m-%Y %H:%M:%S', InvoiceDate)<=@ToDate and CustomerID = @CustomerID",
            //            new { FromDate = param.FromDate, ToDate = param.ToDate, CustomerID = param.CustomerID });
            //    return output.ToList();
            //}
        }

        public List<ReportVM> GetInvoicesByPaymentTypes(ReportParams param)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {

                //var output = con.Query<ReportVM>(@"SELECT * from SalesByPaymentMethodReportView where
                //        strftime('%d-%m-%Y %H:%M:%S', InvoiceDate)>=@FromDate
                //        and strftime('%d-%m-%Y %H:%M:%S', InvoiceDate)<=@ToDate",
                //        new { FromDate = param.FromDate, ToDate = param.ToDate });
                //return output.ToList();

                List<ReportVM> data = new List<ReportVM>();
                var output = con.Query<ReportVM>(@"SELECT * from SalesByPaymentMethodReportView");
                if (output?.ToList().Count > 0)
                {
                    data = new List<ReportVM>();
                    foreach (var item in output.ToList())
                    {
                        DateTime invoiceDate;
                        DateTime.TryParse(item.Date, out invoiceDate);
                        if ((DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) <= DateTime.Parse(param.ToDate.ToString("yyyy-MM-dd"))) &&
                            (DateTime.Parse(invoiceDate.ToString("yyyy-MM-dd")) >= DateTime.Parse(param.FromDate.ToString("yyyy-MM-dd"))) &&
                             item.PaymentMethodID == param.PaymentMethodID
                            )

                        {
                            data.Add(item);
                        }
                    }

                }

                return data;
            }
        }

        public List<Invoice> GetInvoices(string input, string type)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {

                if (type == "InvoiceType")
                {
                    var output = con.Query<Invoice>("SELECT * FROM INVOICE where InvoiceType = @InvoiceType"
                    , new { InvoiceType = input });
                    return output.ToList();
                }
                else if (type == "Name")
                {
                    var output = con.Query<Invoice>(@"SELECT * FROM INVOICE i
                                                    left join InvoiceCustomer ic on i.InvoiceID = ic.InvoiceID
                                                    left join Customer c on ic.CustomerID = c.CustomerID
                                                    where c.Name LIKE '%" + input + "%'"
                                                    , new { InvoiceType = input });
                    return output.ToList();
                }
                else if (type == "Number")
                {
                    var output = con.Query<Invoice>("SELECT * FROM INVOICE where InvoiceNumber LIKE '%" + input + "%'"
                    , new { InvoiceType = input });
                    return output.ToList();
                }
                else
                {
                    var output = con.Query<Invoice>("SELECT * FROM INVOICE where InvoiceDate LIKE '%" + input + "%'"
                    , new { InvoiceType = input });
                    return output.ToList();
                }
            }
        }

        private void UpdateItemsStockForPurchaseInvoice(int id, IDbConnection con)
        {
            try
            {
                var invoiceItems = con.Query<InvoiceItem>("select * from InvoiceItem where InvoiceID = @InvoiceID", new { InvoiceID = id });
                if (invoiceItems != null && invoiceItems.Any())
                {
                    foreach (var item in invoiceItems)
                    {
                        if (item.Quantity > 0)
                        {
                            con.Query(@"UPDATE Product SET [Stock] = [Stock] + @Quantity, ProductPrice = @SalePrice, ProductRawPrice = @PurchasePrice
                                        WHERE ProductID = @ProductID",
                            new { Quantity = item.Quantity, ProductID = item.ProductID, SalePrice = item.SalePrice, PurchasePrice = item.UnitPrice });
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void UpdateItemsStockForInvoice(int invcID, IDbConnection con)
        {
            try
            {

                var invoiceItems = con.Query<InvoiceItem>("select * from InvoiceItem where InvoiceID = @InvoiceID", new { InvoiceID = invcID });
                if (invoiceItems != null && invoiceItems.Any())
                {
                    foreach (var item in invoiceItems)
                    {
                        if (item.Quantity > 0)
                        {
                            con.Query("UPDATE Product SET [Stock] = [Stock] - @Quantity WHERE ProductID=@ProductID",
                            new { Quantity = item.Quantity, ProductID = item.ProductID });
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public bool IsInvoiceDuplicated(string invoiceNumber)
        {
            try
            {
                using (IDbConnection con = new SQLiteConnection(_connectionstring))
                {
                    var output = con.Query<Invoice>
                        (@"SELECT InvoiceNumber FROM Invoice where InvoiceNumber = @InvoiceNumber"
                        , new { InvoiceNumber = invoiceNumber });
                    var val = output?.ToList();
                    return (val == null || val.Any());
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void UpdateStockForCancelledInvoice(int id, IDbConnection con)
        {
            try
            {
                var invoiceItems = con.Query<InvoiceItem>("select * from InvoiceItem where InvoiceID = @InvoiceID", new { InvoiceID = id });
                if (invoiceItems != null && invoiceItems.Any())
                {
                    foreach (var item in invoiceItems)
                    {
                        if (item.Quantity > 0)
                        {
                            con.Query(@"UPDATE Product SET [Stock] = [Stock] + @Quantity WHERE ProductID = @ProductID",
                            new { Quantity = item.Quantity, ProductID = item.ProductID });
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
//string processQuery = "INSERT INTO PROCESS_LOGS VALUES (@A, @B)";
//connection.Execute(processQuery, processList);