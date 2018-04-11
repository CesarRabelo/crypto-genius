using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using crypto.genius.web.Models;

namespace crypto_genius_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var cryptoGram = new Cryptogram();
            cryptoGram.GenerateModelNabopolassar();
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
