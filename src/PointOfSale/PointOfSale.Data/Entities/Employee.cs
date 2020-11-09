using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class Employee
    {
        [DisplayName("ID")]
        public int EmployeeID { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("ID")]
        public string DOB { get; set; }
        public string Gender { get; set; }
        [DisplayName("Father Name")]
        public string FatherName { get; set; }
        public string CNIC { get; set; }
        [DisplayName("Primary Mobile")]
        public string PrimaryMobile { get; set; }
        [DisplayName("Secondary Mobile")]
        public string SecondaryMobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        [DisplayName("Joining")]
        public string JoiningDate { get; set; }
        public int EmploymentStatusID { get; set; }
        public int EmploymentRoleTypeID { get; set; }
        public int WorkShiftID { get; set; }
        public string LastWorkDate { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }
        [DisplayName("Blood Group")]
        public string BloodGroup { get; set; }
        public string EmploymentStatusName { get; set; }
        public string RoleName { get; set; }
        public string WorkShiftName { get; set; }

    }
}
