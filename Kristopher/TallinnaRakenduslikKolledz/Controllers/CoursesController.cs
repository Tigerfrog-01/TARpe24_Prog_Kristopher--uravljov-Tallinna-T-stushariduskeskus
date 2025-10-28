using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledz.Data;
using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Controllers
{
    public class CoursesController : Controller
    {
        private readonly SchoolContext _context;
        public CoursesController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var courses = _context.Courses.Include(c => c.Department)
                .AsNoTracking();

            return View(courses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            PopulateDepartmentsDropDownList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course Courses)
        {
            if (ModelState.IsValid)
            {
           
            _context.Add(Courses);
            await _context.SaveChangesAsync();
            PopulateDepartmentsDropDownList(Courses.DepartmentID);
            }
            return RedirectToAction("Index");
            
        }


        [HttpGet]   
        public async Task<IActionResult> ViewDelete(int?id , string mode)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }
            ViewBag.Mode = mode;
            var courses = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (courses == null)
            {
                return NotFound();
            }
            return View(courses);
        }

        [HttpPost, ActionName("ViewDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deleteconfirmed(int id, string mode)
        {
            if (_context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses.FindAsync(id);
            if(course !=null)
            {
                _context.Courses.Remove(course);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    


        private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Departments
                                   orderby d.Name
                                   select d;
            ViewBag.DepartmentID = new SelectList(departmentsQuery.AsNoTracking(), "DepartmentID", "Name", selectedDepartment);

        }

    }
}
