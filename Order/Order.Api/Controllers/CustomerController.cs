using Microsoft.AspNetCore.Mvc;

namespace Order.Api.Controllers;

public class CustomerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}