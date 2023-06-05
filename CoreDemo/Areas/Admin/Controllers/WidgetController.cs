using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidgetController : Controller
    {
        [Route("Admin/Widget/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
