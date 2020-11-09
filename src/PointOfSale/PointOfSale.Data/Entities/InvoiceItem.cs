using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class InvoiceItem
    {
        public int InvoiceItemID { get; set; }

        public int InvoiceID { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public int IsActive { get; set; }

        public string UnitType { get; set; }
        public decimal TotalPrice { get; set; }

        public int ? SupplierID { get; set; }

        public decimal SalePrice { get; set; }
        
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal ProductRawPrice { get; set; }

    }
}



