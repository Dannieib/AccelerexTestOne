using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccelerexTestOne.Domain;

namespace AccelerexTestOne.Logic
{
    public interface ITimeFormattingService
    {
        Task<string> ProcessTimeFormats(DaysModel model);
    }
}
