using InterviewTestExercise.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterviewTest.UI.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService service)
        {
            _studentService = service;
        }

        public async Task<IActionResult> Index()
        {
            return Ok(await _studentService.GetStudentsAsync());
        }
    }
}
