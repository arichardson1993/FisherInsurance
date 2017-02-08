using Microsoft.AspNetCore.Mvc;

[Route("claim")]
public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
       // return Ok("This is the index of the HomeController");

       return View();
    }
    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        // return Ok("This is the Claims controller for Customer Care");

        return View();
    }
    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
        // return Ok("This is the ClaimHistory method in the CustomerCareController");

        return View();
    }
}