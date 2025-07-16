using Microsoft.AspNetCore.Mvc;

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
}

