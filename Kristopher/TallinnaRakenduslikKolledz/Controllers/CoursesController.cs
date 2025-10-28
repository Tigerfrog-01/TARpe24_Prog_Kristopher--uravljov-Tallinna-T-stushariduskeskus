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
        //-----------------------CREATE--------------------------------------------------------
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["CreateEdit"] = "Create";
            PopulateDepartmentsDropDownList();
            return View("CreateEdit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course Courses)
        {
            if (ModelState.IsValid)
            {
           
            _context.Add(Courses);
            await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            
            }
           
            return View("CreateEdit",Courses);
            
        }
        //-----------------------EDIT--------------------------------------------------------
        [HttpGet]


        public async Task<IActionResult> Edit(int id)
        {
            
            

            var Course = await _context.Courses.FirstOrDefaultAsync(d => d.CourseID == id);

            if (Course == null)
            {
                return NotFound();

            }
            
            ViewData["CreateEdit"] = "Edit"; 
            PopulateDepartmentsDropDownList(Course.DepartmentID);

            return View("CreateEdit", Course);
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("CourseID","Title","Credits","DepartmentID")] Course course)
        {
          
            if (ModelState.IsValid)
            {              
                _context.Update(course);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            PopulateDepartmentsDropDownList(course.CourseID);
            return View("CreateEdit", course);
        }


        //-----------------------------------------------------------------------------------


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
