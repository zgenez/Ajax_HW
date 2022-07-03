using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT141Site.Controllers
{
    public class HWController : Controller
    {
        public IActionResult HW1()
        {
            return View();
        }
    }
}
