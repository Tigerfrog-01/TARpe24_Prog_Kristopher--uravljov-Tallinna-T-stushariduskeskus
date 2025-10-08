using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledz.Data;
using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Controllers

{
    public class InstructorsController : Controller
    {
        private readonly SchoolContext _context;
        public InstructorsController(SchoolContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index(int? id, int? courseId)
        {
            var vm = new InstructorIndexData();
            vm.Instructors = await _context.Instructors
                .Include(i => i.OfficeAssigment)
                .Include(i => i.CourseAssigments)
                .ToListAsync();
            return View(vm);    
        }
        [HttpGet]
        public IActionResult Create()
        {
            var instructor = new Instructor();
            instructor.CourseAssigments = new List<CourseAssigment>();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Instructor instructor,string selectedCourses)
        {
            if (selectedCourses != null)
            {
                instructor.CourseAssigments = new List<CourseAssigment>();

                foreach (var course in selectedCourses)
                {
                    var courseToAdd = new CourseAssigment
                    {
                        InstructorID = instructor.ID,
                        CourseID = course
                    };
                    instructor.CourseAssigments.Add(courseToAdd);
                }
            }
            ModelState.Remove("selectedCourses");
            if (ModelState.IsValid)
            {
                _context.Add(instructor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            PopulateAssignedCourseData(instructor);
            return View(instructor);
        }
        //------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }
            var deletableInstructor = await _context.Instructors
                .FirstOrDefaultAsync(s => s.ID == id);
            if (deletableInstructor == null)
            {
                return NotFound();
            }
            return View(deletableInstructor);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Instructor deletableInstructor = await  _context.Instructors
                .SingleAsync(i => i.ID == id);
            _context.Instructors.Remove(deletableInstructor);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //---------------------------------------------------------------------------------------------
     
        
        //--------------------------------------------------------------------------------------------
        [HttpGet]

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var instructor = await _context.Instructors.FirstOrDefaultAsync(m => m.ID == id);
            if (instructor == null)
            {
                return NotFound();

            }

            return View(instructor);



        }
        //---------------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var instructor = await _context.Instructors.FirstOrDefaultAsync(m => m.ID == id);

            if (instructor == null)
            {
                return NotFound();

            }

            return View(instructor);


        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> EditConfirm([Bind
        ("ID,LastName,FirstName,Nationality,Religion,Gender,Experience,LastJobPlace")] Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                _context.Instructors.Update(instructor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return NotFound();
        }
        //----------------------------------------------------------------------------------------------

        private void PopulateAssignedCourseData(Instructor instructor)
        {
            var allcourses = _context.Courses; //leiame kõik kursused

            var instructorsCourses = new HashSet<int>(instructor.CourseAssigments.Select(c => c.CourseID));
            // valime kursused kus courseid on õpetajal olemas
            var vm = new List<AssignedCourseData>();
            foreach (var course in allcourses)
            {
                vm.Add(new AssignedCourseData
                    {
                    CourseID=course.CourseID,
                    Title = course.Title,
                    Assigned= instructorsCourses.Contains(course.CourseID)
                    });

            }
            ViewData["Courses"] = vm;
        }
    }
}
