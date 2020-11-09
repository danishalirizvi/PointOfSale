using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class Expense
    {
        [DisplayName("ID")]
        public int ExpenseID { get; set; }
        [DisplayName("Expense Category")]
        public string ExpenseName { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }

    }
}
