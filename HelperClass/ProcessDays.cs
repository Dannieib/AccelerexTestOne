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
        public static List<string> IterateAndBox(DaysEnum enums, dynamic model)
        {

            var beautifiedOutput = new List<string>();
            List<string> concat = new List<string>();

            if (enums == DaysEnum.Monday)
            {
                foreach (var item in model)
                {
                    var boxed = (Monday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Add(res);
                }
                var time = String.Join("-", beautifiedOutput);
                var forttingOutput = $"{enums}:{time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Tuesday)
            {
                foreach (var item in model)
                {
                    var boxed = (Tuesday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Add(res);
                }

                var time = String.Join("-", beautifiedOutput);
                var forttingOutput = $"{enums}:{time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Wednesday)
            {
                foreach (var item in model)
                {
                    var boxed = (Wednesday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Add(res);
                }

                var time = String.Join("-", beautifiedOutput);
                var forttingOutput = $"{enums}:{time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Thursday)
            {
                foreach (var item in model)
                {
                    var boxed = (Thursday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Add(res);
                }

                var time = String.Join("-", beautifiedOutput);
                var forttingOutput = $"{enums}:{time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Friday)
            {
                foreach (var item in model)
                {
                    var boxed = (Friday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Add(res);
                }

                var time = String.Join("-", beautifiedOutput);
                var forttingOutput = $"{enums}:{time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Saturday)
            {
                foreach (var item in model)
                {
                    var boxed = (Saturday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Add(res);
                }

                var time = String.Join("-", beautifiedOutput);
                var forttingOutput = $"{enums}:{time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Sunday)
            {
                foreach (var item in model)
                {
                    var boxed = (Sunday) item;
                    var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                    beautifiedOutput.Add(res);
                }

                var time = String.Join("-", beautifiedOutput);
                var forttingOutput = $"{enums}:{time}";
                concat.Add(forttingOutput);
            }
        
            return concat;
        }

        public static string ProcessTimingsAndPeriods(string period, int time)
        {
            string[] timing = { };
            string[] periods = { };
            var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(time).DateTime;
            var dateFortmat = $"{dateTimeOffset:hh:mm:ss tt}";
            return Format(dateFortmat, period);
        }

        private static string Format(string formatTime, string formatPeriod)
        {
            var timesDict = new List<string>();

            if (formatPeriod == "open" )
            {
                timesDict.Add($"{formatTime}");
            }
            else
            { 
                timesDict.Add($"{formatTime}");
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
