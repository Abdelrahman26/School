using Acc.DAL;
using Acc.BL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Acc.Controllers
{
    public class StudentController : Controller
    {
        IStudentManager studentManager;
        ICourseManager courseManager;
        ITeacherRepo teacherRepo;
        public StudentController(ITeacherRepo teacherRepo, IStudentManager studentManager, ICourseManager courseManager)
        {
            this.studentManager = studentManager;
            this.courseManager  = courseManager;
            this.teacherRepo = teacherRepo;
        }
    
        public IActionResult Index()
        {
            //var x = User;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.courses = new SelectList(courseManager.GetAll(), "Id", "Name");
            ViewBag.teachers = new SelectList(teacherRepo.GetAll(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentCourseWriteDto std)
        { 
            studentManager.Add(std);
            return View();
        }
    }
}
