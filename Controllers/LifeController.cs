using Microsoft.AspNetCore.Mvc;

public class LifeController : Controller
{
    public IActionResult Index()
    {
        // return Ok("This is the index of the HomeController");

        return View();
    }
        public IActionResult Quote()
    {
        // return Ok("This is the quote controller for Life");

        return View();
    }

}