using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTTP5101_Assignment3_n01454046.Models;

namespace HTTP5101_Assignment3_n01454046.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Class/List
        public ActionResult List()
        {
            // Instantiating the ClassDataController
            ClassDataController controller = new ClassDataController();
            // Using the information returned from the ListClasses Methods
            IEnumerable<Class> Classes = controller.ListClasses();

            // Sending the information returned to the View
            return View(Classes);
        }

        // GET: /Class/Show/{id}
        public ActionResult Show(int id)
        {
            // Instantiating the ClassDataController
            ClassDataController controller = new ClassDataController();
            // Using the information returned from the FindClass Method
            Class NewClass = controller.FindClass(id);

            // Sending the information returned to the View
            return View(NewClass);
        }
    }
}