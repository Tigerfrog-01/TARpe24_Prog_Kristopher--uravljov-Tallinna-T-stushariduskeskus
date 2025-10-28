
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledz.Data;
using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly SchoolContext _context;

        public DepartmentsController(SchoolContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var schoolContext = _context.Departments.Include(d => d.Adminstrator);
            return View(await schoolContext.ToListAsync());

        }
        //------------------------------------------------------------------------------------------------------------

        //----------------EDIT-----------------------------------------------------

        [HttpGet]


        public async Task<IActionResult> Edit(int id)
        {
            ViewData["EditCreate"] = "Edit";
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments.FirstOrDefaultAsync(d => d.DepartmentID == id);

            if (department == null)
            {
                return NotFound();

            }

            return View("EditCreate", department);
        }

       

      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("DepartmentID,Name,StartDate,Budget,RowVersion,Geography,InstructorID,SchoolName")] Department department, int? id)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Update(department);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View("EditCreate",department);
        }

       //----------------CREATE-----------------------------------------------------


         [HttpGet]
        public IActionResult Create()
        {

            ViewData["InstructorID"] = new SelectList(_context.Instructors, "ID,FirstName");
            ViewData["EditCreate"] = "Create";



            return View("EditCreate");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DepartmentID,Name,StartDate,Budget,RowVersion,Geography,InstructorID,SchoolName")] Department department, int? id)
        {
            ModelState.Remove("mode");
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["InstructorID"] = new SelectList(_context.Instructors, "ID", "FirstName", department.InstructorID);
            return NotFound();

        }





            //------------------------------------------------------------------------------------------------------------

            [HttpGet]
        public async Task<IActionResult> ViewDelete(int? id,string mode)
        {



            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Mode = mode;
            var department = await _context.Departments
                .Include(d => d.Adminstrator)
                .FirstOrDefaultAsync(d => d.DepartmentID == id);
            if (department == null)
            {
                return NotFound();

            }

          




            return View(department);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ViewDelete(Department department)
        {
            if (await _context.Departments.AnyAsync(m => m.DepartmentID == department.DepartmentID))
                {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
            }

       


            return RedirectToAction("Index");





        }
      
    }
}
