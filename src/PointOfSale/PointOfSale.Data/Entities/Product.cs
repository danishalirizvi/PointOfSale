using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int IsActive { get; set; }
        public decimal Stock { get; set; }
        public string StockDate { get; set; }
        public decimal ProductRawPrice { get; set; }
        public string ProductType { get; set; }
        public string ProductCode { get; set; }
        public string UnitType { get; set; }
        
    }
}
