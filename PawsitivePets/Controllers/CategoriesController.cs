using Microsoft.AspNetCore.Mvc;
using PawsitivePets.Models;
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
            // use the Category model to generate a list of 10 mock category objects
            var categories = new List<Category>();

            for (var i = 1; i < 11; i++)
            {
                categories.Add(new Category { CategoryId = i, Name = "Category " + i.ToString() });
            }

            // pass the categories list to the view for display
            return View(categories);
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

        // /Categories/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
