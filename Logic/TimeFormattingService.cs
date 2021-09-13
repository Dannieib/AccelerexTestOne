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
            var Formatted = string.Empty;

            foreach (var item in dict)
            {
                if (item.Value.Count<=0)
                {
                    response.Add(new DayResponseModel
                    {
                        Formatted = $"{item.Key}: {Close}"
                    });
                }
                else
                {
                    foreach(var i in item.Value)
                    {
                        var resp = ProcessDays.IterateAndBox((DaysEnum)item.Key, item.Value);
                        response.Add(new DayResponseModel
                        {
                            Formatted = String.Join(",", resp)
                        });
                    }
                }
            }

            //for
            return JsonConvert.SerializeObject(Formatted);
        }
    }
}
