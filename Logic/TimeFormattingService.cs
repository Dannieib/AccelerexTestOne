using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using AccelerexTestOne.Domain;
using AccelerexTestOne.HelperClass;
using Newtonsoft.Json;

namespace AccelerexTestOne.Logic
{
    public class TimeFormattingService
    { 

        public string Close = "CLOSED";
        public string Open = "OPEN";

        public async Task<string> ProcessTimeFormats(DaysModel model)
        {
            //string[] days_to_process =
            //    {"monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"};

            var dict = new Dictionary<Enum, dynamic>
            {
                {DaysEnum.Monday, model.monday},
                {DaysEnum.Tuesday, model.tuesday},
                {DaysEnum.Wednesday, model.wednesday},
                {DaysEnum.Thursday, model.thursday},
                {DaysEnum.Friday, model.friday},
                {DaysEnum.Saturday, model.saturday},
                {DaysEnum.Sunday, model.sunday}
            };

            var response = new List<DayResponseModel>();

            foreach (var item in dict)
            {
                if (item.Value.Count<=0)
                {
                    response.Add(new DayResponseModel
                    {
                        Formatted = $"{item.Key}: {Close}",
                    });
                }
                else
                {
                    foreach(var i in item.Value)
                    {
                        ProcessDays.IterateAndBox((DaysEnum)item.Key, item.Value);// ((DaysEnum)item.Key, item.Value);
                        response.Add(new DayResponseModel
                        {
                            Formatted = $"{item.Key}: {(object)i}",
                        });
                    }
                }
            }

            return JsonConvert.SerializeObject(response);
        }

       
    

        //private ValueModel Process(DaysModelDto dayDto)
        //{
        //    string[] period = { };
        //    var eee = new DaysModelDto();

        //  if(dayDto.)
        //    return dto;
        //}

        //public Task<DateTime> DatetimeFormatterHelper(int time, string periodDesc)
        //{
        //    if (time > 0)
        //    {
        //        return 
        //    }

        //    return null;
        //}
        

    }
}
