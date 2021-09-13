using System;
using System.Collections.Generic;
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
                beautifiedOutput = HandleLogic(model);
                var time = String.Join(" - ", beautifiedOutput);
                var forttingOutput = $"{enums}: {time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Tuesday)
            {
                beautifiedOutput = HandleLogic(model);

                var time = String.Join(" - ", beautifiedOutput);
                var forttingOutput = $"{enums}: {time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Wednesday)
            {
                beautifiedOutput = HandleLogic(model);

                var time = String.Join(" - ", beautifiedOutput);
                var forttingOutput = $"{enums}: {time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Thursday)
            {
                beautifiedOutput = HandleLogic(model);

                var time = String.Join(" - ", beautifiedOutput);
                var forttingOutput = $"{enums}: {time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Friday)
            {
                beautifiedOutput = HandleLogic(model);
                var time = String.Join(" - ", beautifiedOutput);
                var forttingOutput = $"{enums}: {time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Saturday)
            {
                beautifiedOutput = HandleLogic(model);
                var time = String.Join(" - ", beautifiedOutput);
                var forttingOutput = $"{enums}: {time}";
                concat.Add(forttingOutput);
            }
            else if (enums == DaysEnum.Sunday)
            {
                beautifiedOutput = HandleLogic(model);
                var time = String.Join(" - ", beautifiedOutput);
                var forttingOutput = $"{enums}: {time}";
                concat.Add(forttingOutput);
            }

            return concat;
        }

        public static List<string> HandleLogic(dynamic boxedModel)
        {
            var response = new List<string>();
            foreach (var item in boxedModel)
            {
                var boxed = item;
                var res = ProcessTimingsAndPeriods(boxed.type, boxed.value);
                response.Add(res);
            }

            var resp = RemoveMoreThanTwoIndex(response);
            
            return resp;
        }

        public static string ProcessTimingsAndPeriods(string period, int time)
        {
            var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(time).DateTime;
            var dateFormat = $"{dateTimeOffset:hh:mm:sstt}";
            return Format(dateFormat, period);
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

        public static List<string> RemoveMoreThanTwoIndex(List<string> Formatted)
        {
            var res = new List<string>();
            if (Formatted.Count > 2)
            {
                Formatted.RemoveAt(0);
                res = Formatted;
            }
            else
            {
                res = Formatted;
            }
            return res;
        }
    }
}
