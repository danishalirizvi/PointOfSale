using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class EmploymentRole
    {
        public int RoleTypeID { get; set; }
        public string RoleName { get; set; }
        public double BasicSalary { get; set; }
        public string Description { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }
    }
}
