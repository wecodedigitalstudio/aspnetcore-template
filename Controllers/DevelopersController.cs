using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetcore_template.Models;

namespace aspnetcore_template.Controllers
{
    public class DevelopersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
