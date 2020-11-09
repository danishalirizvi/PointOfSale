using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.Entities
{
    public class WorkShift
    {
        public int WorkShiftID { get; set; }
        public string WorkShiftName { get; set; }
        public string Description { get; set; }
        public string ShiftStartTime { get; set; }
        public string ShiftEndTime { get; set; }
        public int IsActive { get; set; }
        public int IsBlocked { get; set; }

    }
}
