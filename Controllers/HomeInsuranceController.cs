using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;

public class HomeInsuranceController : Controller
{
    public IActionResult Index()
    {
        // return Ok("This is the index of the HomeInsuranceController");

        return View();
    }
    public IActionResult Quote()
    {
        // return Ok("This is the quote method in the HomeInsuranceController");
       Quote quote = new Quote
       {
           Id = 345,
           Product = "Home Insurance",
           ExpireDate = DateTime.Now.AddDays(45),
           Price = 45.00M

       };
        return View(quote);
    }
}