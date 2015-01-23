using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(User());
        }

        public User User()
        {
            User user = new User()
            {
                Nombre = "Gfx | GeoMarketing",
                Email = "eherrador@icloud.com",
                Ciudad = "México, D.F.",
                Facebook = "https://www.facebook.com/edgar.herrador",
                Twitter = "@eherrador",
                Github = "https://github.com/eherrador"
            };

            return user;
        }
    }
}