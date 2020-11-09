using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class RunningNumber
    {
        public string InvoiceType { get; set; }
        public string LastRuningNumber { get; set; }
        public string MaxRunningNumber { get; set; }
    }
}
