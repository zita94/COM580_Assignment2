using Students.Models.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Students.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository repository = null;

        public StudentController() 
        {
            this.repository = new StudentRepository(); 
        }

        public StudentController(IStudentRepository repository)
        {
            this.repository = repository;
        }

        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            List<Student> students = repository.GetAllStudents().ToList();
            return View(students);
        }

        [HttpGet]
        public ActionResult Details(int id) 
        {
            Student student = repository.SelectByID(id);
            return View(student);
        }

        [HttpGet]
        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student) 
        { 
            if (ModelState.IsValid)
            {
                repository.Insert(student);
                repository.Save();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        [HttpGet, ActionName("Edit")]
        public ActionResult ConfirmEdit(int id) 
        {
            Student student = repository.SelectByID(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                repository.Update(student);
                repository.Save();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        [HttpGet, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id) 
        {
            Student student = repository.SelectByID(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
            return RedirectToAction("Index");
        }
    }
}