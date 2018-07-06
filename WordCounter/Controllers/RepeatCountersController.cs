using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordCounter.Models;


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
        public ActionResult Count(string wordToFind, string stringToSearch)
        {
            RepeatCounter newCounter = new RepeatCounter();
            newCounter.SetWordToFind(wordToFind);
            newCounter.SetStringToSearch(stringToSearch);
            newCounter.UpdateWordCounter();

            return View(newCounter);
        }
    }
}
