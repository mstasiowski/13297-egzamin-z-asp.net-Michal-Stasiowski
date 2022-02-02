using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _13297_zaliczenie_wyklad;
using _13297_zaliczenie_wyklad.Models;

namespace _13297_zaliczenie_wyklad.Controllers
{
    public class ApiMarkController : Controller
    {
        [Route("api/exams")]
        [ApiController]
        public class ApiContactController : ControllerBase
        {

            [HttpGet]
            public List<Mark> GetMarks()
            {
                return new List<Mark>()
            {
                new Mark()
                {
                    Id=2,
                    album =13297,
                    points = 51
                },
                new Mark()
                {
                    Id=3,
                    album =13222,
                    points = 55
                }

             };
            }

            [HttpPost]
            public IActionResult AddMark([FromBody] Mark mark)
            {

                mark.Id = 3;
                return new CreatedResult($"/api/exams/{mark.Id}", mark);


            }

            [HttpGet]
            public ActionResult<Mark> GetMark(int id)
            {
                
                if (id < 3 && id > 0)
                {
                    return new OkObjectResult(new Mark() { Id = id, album = 1333, points = 40 });
                }
                else
                {
                    return new NotFoundResult();
                }
            }
        }
    }
}
