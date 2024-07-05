using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModel;
using WebApi.Data;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext studentContext;
        public StudentController(StudentContext studentContext)
        {
            this.studentContext = studentContext;
        }

        [HttpGet("getAllStudents")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            var students = await studentContext.students.ToListAsync();

            return Ok(students);
        }
    }
}