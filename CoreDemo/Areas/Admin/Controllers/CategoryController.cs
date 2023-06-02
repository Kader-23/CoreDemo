using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        [AllowAnonymous]
       [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
