using Microsoft.AspNetCore.Mvc;

[Route("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeController");
    }
    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the Claims controller for Customer Care");
    }
    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the ClaimHistory method in the CustomerCareController");
    }
}