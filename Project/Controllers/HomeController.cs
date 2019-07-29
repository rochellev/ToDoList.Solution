using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        // routes go here

          [Route("/")]
        public ActionResult Index()
        {
          ProjectClass starterItem = new ProjectClass("Add first item to To Do List");
          return View(starterItem);
        }

    }
}