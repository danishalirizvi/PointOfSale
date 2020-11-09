using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class SalesPerson
    {
        public int SalesPersonID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string CNIC { get; set; }
        public int IsActive { get; set; }
    }
}
