using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {

            ViewBag.Party = "Party is closer";
            return View("Index");
        }

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (!ModelState.IsValid) {
                return View();
            }

            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }

        [HttpGet]
        public ViewResult ListResponses() {
            return View(Repository.Responses.Where(t => t.WillAttend == true));
        }
    }
}
