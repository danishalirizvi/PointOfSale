using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI.ViewModel
{
    public class PurchaseInvoiceItemVm
    {
        [DisplayName("Product ID")]
        public int ProductID { get; set; }
     
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [DisplayName("Supplier ID")]
        public int SupplierID { get; set; }

        [DisplayName("Supplier Name")]
        public string SupplierName { get; set; }

        [DisplayName("Purchase Price")]
        public decimal PurchasePrice { get; set; }
        [DisplayName("Sale Price")]
        public decimal SalePrice { get; set; }
        [DisplayName("Unit")]
        public string UnitType { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; }
    }
}
