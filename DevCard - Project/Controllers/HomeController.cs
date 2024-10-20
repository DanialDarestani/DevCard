using DevCard___Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DevCard___Project.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard___Project.Controllers
{
    //[Route("/home/")]
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new (1,"نقره ای"),
            new (2,"طلایی"),
            new (3,"پلاتین"),
            new (4,"الماس")
        };
        public HomeController()
        {
        }

        //[Route("index")]
        public IActionResult Index(int id)
        {
            Console.WriteLine("Number: " + id);
            return View();
        }
        public IActionResult ProjectDetails(int id)
        {
            var project = ProjectStore.GetProjectBy(id);
	        return View(project);
        }


        [HttpGet("contact/{n?}/{m?}")]
        //[HttpGet]
        public IActionResult Contact(string n,int m)
        {
            Console.WriteLine("Name: " + n);
            var model = new Contact {Services = new SelectList(_services,"Id","Name")};
            return View(model);
            /*return PartialView("Contact");*/
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد. لطفا دوباره تلاش کنید.";
                return View(model);
            }

            ModelState.Clear();
            model = new Contact { Services = new SelectList(_services, "Id", "Name") };
            ViewBag.success = "نظر شما با موفقیت ثبت شد.";
            return View(model);
        }


        public ViewResult Test1()
        {
            return View("Components/HeaderViewComponents/_Header");
        }
        public PartialViewResult Test2()
        {
            return PartialView("Components/ArticlesViewComponents/_Article");
        }
        public ViewComponentResult Test3()
        {
            return ViewComponent("");
        }
        public ContentResult Test4()
        {
            return Content("<h1 style='color: red'>Hello</h1>");
        }
        public EmptyResult Test5()
        {
            return new EmptyResult();
        }
        public FileResult Test6()
        {
            return File("~/test.txt","text/html");
        }
        public JsonResult Test7()
        {
            return Json(new
                {
                    id=12, 
                    name= "Danial", 
                    job="Programmer"
                }
            );
        }
        public JavaScriptResult Test8()
        {
            return new JavaScriptResult("alert('Hello World!!')");
        }

        public RedirectResult Test9()
        {
            return Redirect("https://www.atriya.com");
        }
        public RedirectToActionResult Test10()
        {
            return RedirectToAction("Contact","Home");
        }

        public IActionResult Status()
        {
            return new StatusCodeResult(404);
            return new NotFoundResult();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class JavaScriptResult(string data) : ContentResult
    {
        public string Content { get; set; } = data;
        public string ContentType { get; set; } = "application/javascript";
    }
}
