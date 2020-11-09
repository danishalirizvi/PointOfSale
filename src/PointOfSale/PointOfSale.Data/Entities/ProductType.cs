using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class ProdType
    {
        [DisplayName("Product Type")]
        public string ProductType { get; set; }
        public string Description { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }
    }
}
