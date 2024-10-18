using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // https://localhost:portNumber/api/Student
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET : https://localhost:portNumber/api/Student
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] students = {"John", "Jane", "Luke", "Robin"};

            return Ok(students);
        }
    }
}
