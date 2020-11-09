using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class Supplier
    {
        [DisplayName("ID")]
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        [DisplayName("Company")]
        public string CompanyName { get; set; }
        [DisplayName("Primary Mobile")]
        public string PrimaryMobile { get; set; }
        [DisplayName("Secondary Mobile")]
        public string SecondaryMobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }


    }
}
