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
    public class TimeFormattingService: ITimeFormattingService
    { 

        public string Close = "CLOSED";
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
            List<string> output = new List<string>();

            foreach (var item in dict)
            {
                if (item.Value.Count<=0)
                {
                    output.Add($"{item.Key}: {Close}");
                }
                else
                {
                    foreach(var i in item.Value)
                    {
                        var resp = ProcessDays.IterateAndBox((DaysEnum)item.Key, item.Value);
                        var dictResp = new Dictionary<string, List<string>>
                        {
                            {item.Key.ToString(), resp}
                        };

                        foreach (var dictItem in dictResp)
                        {
                            if (!output.Contains(dictItem.Value[0]))
                            {
                                output.Add(String.Join(",", dictItem.Value));
                            }
                        }
                    }
                }
            }
            return JsonConvert.SerializeObject(output);
        }
    }
}
