using Microsoft.AspNetCore.Mvc;

namespace MapProjAPI.Controllers.Events
{
  public class EventsController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }

}
