using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult New()
    {
      return RedirectToAction("Index");
    }
  }
}