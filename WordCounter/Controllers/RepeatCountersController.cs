using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WordCounter.Controllers
{
    public class RepeatCountersController : Controller
    {   
        [HttpGet("repeatCounters/start")]
        public ActionResult Start()
        {
            return View();
        }

        [HttpPost("/count")]
        public ActionResult Count()
        {
            return View();
        }
    }
}
