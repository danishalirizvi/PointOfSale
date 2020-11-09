using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class InvoiceCustomer
    {
        public int InvoiceCustomerID { get; set; }
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal SalesTax { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal ChangeAmount { get; set; }
        public decimal DueAmount { get; set; }

        public decimal DiscountPercentage { get; set; }
        public decimal DiscountPercentageAmount { get; set; }
        public decimal FixedDiscount { get; set; }
        public int SalesPersonID { get; set; }
    }
}
