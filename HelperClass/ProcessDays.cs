using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AccelerexTestOne.Domain;

namespace AccelerexTestOne.HelperClass
{
    public static class ProcessDays
    {
        //public static string[] ProcessDaysObject(DaysModelDto model)
        //{
        //    string[] periods = { };
        //    DateTime[] timing = { };

        //    var res = model switch
        //    {

        //    };
        //    return res;

        //}

        public static dynamic IterateAndBox(DaysEnum enums, dynamic model)
        {

            string[] beautifiedOutput = { };

            foreach (var item in model)
            {
                if (enums == DaysEnum.Monday)
                {
                    var boxed = (Monday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Append(res);
                }
                else if (enums == DaysEnum.Tuesday)
                {
                    
                    var boxed = (Tuesday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Append(res);
                }
                else if (enums == DaysEnum.Wednesday)
                {
                    var boxed = (Wednesday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Append(res);
                }
                else if (enums == DaysEnum.Thursday)
                {
                    var boxed = (Thursday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Append(res);
                }
                else if (enums == DaysEnum.Friday)
                {
                    
                    var boxed = (Friday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Append(res);
                }
                else if (enums == DaysEnum.Saturday)
                {
                    var boxed = (Saturday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Append(res);
                }
                else if (enums == DaysEnum.Sunday)
                {
                    var boxed = (Sunday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Append(res);
                }
            }
            return beautifiedOutput;
        }

        public static string ProcessTimingsAndPeriods(string period, int time)
        {
            string[] timing = { };
            string[] periods = { };
            var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(time).TimeOfDay;
            //timing.Append($"{dateTimeOffset:hh:mm:ss tt}");
            //periods.Append(period);

            return Format($"{dateTimeOffset:hh:mm:ss tt}", period);
        }

        private static string Format(string formatTime, string formatPeriod)
        {
            string[] timesDict = {};

            if (formatTime == "open" )
            {
                timesDict.Append($"{formatTime}");
            }
            else
            { 
                timesDict.Append($"{formatTime}");
            }
        
            return String.Join(" ", timesDict);

        }

        public static string FormatPeriod(string periods)
        {
            var format = periods switch
            {
                "close" => "",
                "open" => "-",
                _ => string.Empty
            };
            return format;
        }
    }
}
