using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class LoginUser
    {
        [DisplayName("ID")]
        public int LoginUserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [DisplayName("Employee ID")]
        public int EmployeeID { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }
        public string ExpiryDate { get; set; }
        public int InvalidAttempt { get; set; }
        public int AllowedAttempt { get; set; }
        public int MaxPasswordLength { get; set; }
        public int MinPasswordLength { get; set; }
        public int IsAdmin { get; set; }
    }
}
