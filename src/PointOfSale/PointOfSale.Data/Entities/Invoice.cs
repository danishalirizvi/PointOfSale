using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class Invoice
    {
        public int InvoiceID { get; set; }         
        public string InvoiceDate { get; set; }    
        public decimal TotalToPay { get; set; }
        public string Comment { get; set; }       
        public int IsActive { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceNumber { get; set; }
        public int PaymentMethodID { get; set; }
        public string InvoiceStatus { get; set; }
        public int ReferenceInvoiceID { get; set; }
        public string ReferenceInvoiceNumber { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public InvoiceCustomer invcCustomer { get; set; }
    }
}

 