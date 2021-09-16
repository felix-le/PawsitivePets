using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivePets.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // add a new method that's called when user clicks a category from the list displayed
        // method accepts a string value in the url called "category"
        public IActionResult Browse(string category)
        {
            // if category is empty / missing, take user back to category list
            if (category == null)
            {
                return RedirectToAction("Index");
            }

            // Store the input parameter in the ViewBag to display in the view
            ViewBag.category = category;

            return View();
        }
    }
}
