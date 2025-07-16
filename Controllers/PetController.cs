using Microsoft.AspNetCore.Mvc;
using ModelBindingPractice_Pet.Models;

namespace ModelBindingPractice_Pet.Controllers;

public class PetController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Pet p) 
    {
        if (ModelState.IsValid)
        {
            //add pet to database

            //redirect to index
            return RedirectToAction("Index");
        }

        //show web page with error messages
        return View(p);
    }
}

