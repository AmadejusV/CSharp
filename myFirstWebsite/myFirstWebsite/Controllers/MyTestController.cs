using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstWebsite.Controllers
{
    public class MyTestController : Controller
    {
        [Route("[controller]")]
        public int Pitakas()
        {
            return 5;
        }
    }
}
