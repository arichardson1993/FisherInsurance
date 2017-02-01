using Microsoft.AspNetCore.Mvc;

public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeController");
    }
    public IActionResult Claims()
    {
        return Ok("This is the Claims controller for Customer Care");
    }
}