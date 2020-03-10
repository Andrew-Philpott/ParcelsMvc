using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Threading.Tasks;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult New(int width, int length, int depth, double weight)
    {
      Parcel parcel = new Parcel(width, length, depth, weight);
     
      TryValidateModel(parcel);

      if (ModelState.IsValid)
      {
        return View("Index", parcel);
      }

      return View("New");
    }
  }
}