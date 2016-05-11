using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using veg1.Models;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace veg1.Controllers
{
    public class HomeController : Controller
    {
        private veg1Context db = new veg1Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult AnotherTest(string data)
        {


            Random rnd = new Random();
            int x = rnd.Next(1, 22);


            Recipe recipe = db.Recipes.Find(x);

            Console.WriteLine(data);
            //Console.WriteLine(count);
            string notUsedString = "We Got To Sam's Test Controller";
            //return Content(notUsedString, "application/json");
            //var json = new JavaScriptSerializer().Serialize(menuGroup);

            //            Recipe recipe = db.Recipes.Find(id);
            //  if (recipe == null)
            //  {
            //     return HttpNotFound();
            //}
            //return View(recipe);


            var json = JsonConvert.SerializeObject(recipe,
                Formatting.None,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    });



            return Json(json);
        }
    }
}