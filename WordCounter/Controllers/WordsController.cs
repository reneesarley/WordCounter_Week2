using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordsController : Controller
    {
        [HttpGet("words/WordScorer")]
        public ActionResult WordScorer()
        {
            return View();
        }

        [HttpPost("scoreResult")]
        public ActionResult ScoreResult()
        {
            return View();
        }
    }
}
