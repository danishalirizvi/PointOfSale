using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Params
{
    public class ReportParams
    {
        public string ExpenseName { get; set; }
        public string PaymentMethod { get; set; }
        public int PaymentMethodID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int SalesPersonID { get; set; }
    }
}
