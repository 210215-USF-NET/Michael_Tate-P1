using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Controllers
{
    public class ShoppingController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}