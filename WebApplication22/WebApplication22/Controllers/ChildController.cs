using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication22.Controllers
{
    public class ChildController : Controller
    {
        public IActionResult MyChildrend()
        {
            return View();
        }
    }
}
