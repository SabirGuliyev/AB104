using Microsoft.AspNetCore.Mvc;
using ViewBagExample.Models;

namespace ViewBagExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Sabuhi", Surname = "Camalzade" });
            students.Add(new Student { Id = 2, Name = "Yusif", Surname = "Celilli" });
            students.Add(new Student { Id = 3, Name = "Shamama", Surname = "Guliyeva" });
            students.Add(new Student { Id = 4, Name = "Zuzu", Surname = "Qurbanova" });

            return View(students);



            //ViewBag.Students = students;

            //ViewData["Students"] = students;





        }
        public IActionResult About()
        {

            //string name = TempData["Name"].ToString();
            //TempData.Keep("Name");

            //Console.WriteLine(name);

            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Sabuhi", Surname = "Camalzade" });
            students.Add(new Student { Id = 2, Name = "Yusif", Surname = "Celilli" });
            students.Add(new Student { Id = 3, Name = "Shamama", Surname = "Guliyeva" });
            students.Add(new Student { Id = 4, Name = "Zuzu", Surname = "Qurbanova" });


            return View(students);
        }

        public IActionResult Test()
        {
            return Content(TempData["Name"].ToString());
        }
    }
}
