using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public decimal PercentDiscount { get; set; }
        public string Mobile { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }
        public decimal DueAmount { get; set; }
    }
}

