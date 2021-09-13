using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccelerexTestOne.Domain;
using AccelerexTestOne.Logic;

namespace AccelerexTestOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OpeningHoursController : ControllerBase
    {
        public OpeningHoursController()
        {
            
        }

        [HttpPost]
        public async Task<IActionResult> ProcessOpeningHours(DaysModel model)
        {
            var output = await new TimeFormattingService()
                                                             .ProcessTimeFormats(model);
            return Ok(output);
        }
    }
}
