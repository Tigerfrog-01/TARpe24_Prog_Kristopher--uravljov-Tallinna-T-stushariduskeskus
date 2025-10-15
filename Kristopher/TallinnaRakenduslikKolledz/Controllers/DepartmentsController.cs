
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
        [HttpGet]
        public IActionResult EditCreate()
        {
            ViewData["InstructorID"] = new SelectList(_context.Instructors, "ID,FirstName");
                
         
          
          
                return View();
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCreate([Bind("DepartmentID,Name,StartDate,Budget,RowVersion,Geography,InstructorID,SchoolName")] Department department, string mode)
        {

            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            if ()
            {

            }

            ViewData["InstructorID"] = new SelectList(_context.Instructors, "ID","FirstName", department.InstructorID);
            return RedirectToAction("Index");


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
        public async Task<IActionResult> ViewDelete(Department department,string mode)
        {
            if (await _context.Departments.AnyAsync(m => m.DepartmentID == department.DepartmentID))
                {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
            }

            if (mode == "Edit")
            {
                _context.Departments.Update(department);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }


            return RedirectToAction("Index");





        }
      
    }
}
