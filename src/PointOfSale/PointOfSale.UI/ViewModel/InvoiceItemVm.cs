using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI.ViewModel
{
    public class InvoiceItemVm
    {
        [DisplayName("Product ID")]
        public int ProductID { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }
        
        [DisplayName("Unit")]
        public string UnitType { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Total Amount")]
        public decimal TotalAmount { get; set; }
        [DisplayName("Raw Price")]
        public decimal ProductRawPrice { get; set; }
     
    }

}

