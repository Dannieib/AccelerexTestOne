using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccelerexTestOne.Domain
{
    public class DayResponseModel
    {
        public string Formatted { get; set; }
    }

    public class DaysModelDto
    {
        public Monday Monday { get; set; }
        public Tuesday Tuesday { get; set; }
        public Wednesday Wednesday { get; set; }
        public Thursday Thursday { get; set; }
        public Friday Friday { get; set; }
        public Saturday Saturday { get; set; }
        public Sunday Sunday { get; set; }
    }
}
