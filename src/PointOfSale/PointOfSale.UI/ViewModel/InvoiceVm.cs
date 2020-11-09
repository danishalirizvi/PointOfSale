using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI.ViewModel
{
    public class InvoiceVm
    {
        public InvoiceVm() {
            invoiceItems = new List<InvoiceItemVm>();
        }
        public int? CustomerID { get; set; }
      
        public int ReferenceInvoiceID { get; set; }
 
        public string RefereneInvoiceNumber { get; set; }

        public List<InvoiceItemVm> invoiceItems { get; set; }
    }
}
