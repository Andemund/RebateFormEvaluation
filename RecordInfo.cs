using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class RecordInfo
    {
        public string InfoID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan FinishTime { get; set; }
        public TimeSpan IntervalTime { get; set; }

        public string BackNum { get; set; }
        public TimeSpan TotalTime { get; set; }

        public TimeSpan Get_Total_Time()
        {
            TimeSpan diff = FinishTime - StartTime;
            return diff;
        }
    }
}
