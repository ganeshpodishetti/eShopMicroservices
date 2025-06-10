using Microsoft.AspNetCore.Mvc;

namespace Order.Api.Controllers;

public class OrderController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}