using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.ReportViews
{
    public class SupplierReportVM
    {
        public string  InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
