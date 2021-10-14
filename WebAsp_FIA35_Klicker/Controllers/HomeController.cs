using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAsp_FIA35_Klicker.Controllers
{

    public class HomeController : Controller
    {
        int count;

        public HomeController()
        {
            count = 0;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string btn, int zaehler)
        {
            if (btn == "BtnClickCount")
            {
                count = zaehler + 1;
                ViewBag.Count = count;
            }

            if (btn == "BtnClickShowCount")
            {
                ViewBag.Count = count;
                count = zaehler + 1;                
            }

            return View();
        }


    }
}
