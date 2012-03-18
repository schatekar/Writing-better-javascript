using System.Web.Mvc;

namespace Better_Javascript.Controllers
{
    public class ToDoController : Controller
    {
         public ActionResult GetAll()
         {
             return View();
         }
    }
}