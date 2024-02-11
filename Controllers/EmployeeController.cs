using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVC_App2.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}