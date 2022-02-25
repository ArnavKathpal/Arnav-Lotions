using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace Arnav_Lotions.Controllers
{
    public class Arnav_LotionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Arnav_Lotions/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
