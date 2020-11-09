using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class PaymentMethod
    {
        [DisplayName("ID")]
        public int PaymentMethodID { get; set; }
        [DisplayName("Method")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }

    }
}
