using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _13297_zaliczenie_wyklad.Models;

namespace _13297_zaliczenie_wyklad.Controllers
{
    public class MarkController : Controller
    {
        public static List<Mark> marks = new List<Mark>()
        {
            new Mark(){Id=1, album=13297, points=50},
           

        };

        static int index = 2;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddMark()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Mark mark)
        {
            if (ModelState.IsValid)
            {
                mark.Id = index++;
                marks.Add(mark);
                return View("ConfirmMark", mark);
            }
            else
            {
                return View("AddMark");
            }
        }
        [HttpGet]
        public IActionResult List()
        {
            return View(marks);
        }

    }
}
