using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index(int page = 1)  
        {
            var values = cm.GetList().OrderByDescending(p=> p.CategoryId).ToPagedList(page, 3);
            return View(values);
        }

        
        [Route("Admin/Category/AddCategory")]
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

       [AllowAnonymous]
        [HttpPost]
        [Route("Admin/Category/AddCategory")]
        public IActionResult AddCategory(Category p)
        {


            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);


            if (results.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Category");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }


        public  IActionResult DeleteCategory(int id)
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");

        }
    }
}
