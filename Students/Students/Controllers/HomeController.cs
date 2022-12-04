using System.Web.Mvc;

namespace Students.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.AboutMessage = "This web application is for creating, editing, deleting and listing details of " +
                "international students with the information stored in a supporting database.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.ContactMessage = "Created by:";

            return View();
        }
    }
}