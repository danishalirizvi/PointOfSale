using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI.ViewModel
{
    public class CalculateValuesVm
    {
        public CalculateValuesVm() {
            FixedDiscount = 0;
            PercentageDiscount = 0;
            TotalAmount = 0;
            TotalDiscount = 0;
            TotalToPay = 0;
            DueAmount = 0;
            ChangeAmount = 0;
        }
        public decimal FixedDiscount { get; set; }

        public decimal PercentageDiscount { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalToPay { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal DueAmount { get; set; }

        public decimal ReceivedAmount { get; set; }

        public decimal ChangeAmount { get; set; }
    }
}
