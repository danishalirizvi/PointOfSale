using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class ExpenseCategory
    {
        [DisplayName("Expense Category")]
        public string ExpenseName { get; set; }
        public string Description { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }

    }
}
