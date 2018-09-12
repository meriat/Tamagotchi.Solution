using Microsoft.AspNetCore.Mvc;

namespace Tamagotchis.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
