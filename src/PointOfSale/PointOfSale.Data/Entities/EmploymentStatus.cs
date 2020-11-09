using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class EmploymentStatus
    {
        public int EmploymentStatusID { get; set; }
        public string EmploymentStatusName { get; set; }
        public string Description { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }
    }
}
