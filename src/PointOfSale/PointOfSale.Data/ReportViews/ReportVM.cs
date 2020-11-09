using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI.ViewModel
{
    public class ReportVM
    {
        public int ProductID { get; set; }
        public string Product { get; set; }
        public string Customer { get; set; }
        public int CustomerID { get; set; }
        public string Mobile { get; set; }
        public string Date { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalToPay { get; set; }
        public string InvoiceType { get; set; }
        public decimal Received { get; set; }
        public int Quantity { get; set; }
        public string UnitType { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int PaymentMethodID { get; set; }
        public string PaymentMethod { get; set; }
        public decimal ProductRawPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountPercentageAmount { get; set; }
        public decimal FixedDiscount { get; set; }
        public decimal ChangeAmount { get; set; }
        public string SalesPerson { get; set; }
        public int SalesPersonID { get; set; }
    }
}
