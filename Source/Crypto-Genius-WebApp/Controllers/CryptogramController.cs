using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CryptoGeniusWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CryptoGeniusWebApp.Controllers
{
    public class CryptogramController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /<controller>/play string player, Guid crytogramId
        public IActionResult Play(){

            Cryptogram crypto = new Cryptogram();
            crypto.GenerateModelPartidaEmpatada();
            //crypto.GenerateModelNabopolassar();

            //ViewBag.Player = HtmlEncoder.Default.Encode(player);
            //ViewBag.CrytogramId = crytogramId;
            return View(crypto);
        }
    }
}
