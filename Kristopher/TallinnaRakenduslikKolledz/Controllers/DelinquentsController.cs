using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledz.Data;
using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Controllers
{
    public class DelinquentsController : Controller
    {
        private readonly SchoolContext _context;




        public async Task<IActionResult> Index()
        {
            return View(await _context.delinquents.ToListAsync());

        }
        public DelinquentsController(SchoolContext context)
        {

            _context = context;

        }


        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind
        ("ID,FirstName,LastName,Violation,Subject,CurrentSituation")] Delinquents delinquents)
        {
            if (ModelState.IsValid)
            {
                _context.delinquents.Add(delinquents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(delinquents);
        }

        [HttpGet]

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var delinquents = await _context.delinquents.FirstOrDefaultAsync(m => m.ID == id);
            if (delinquents == null)
            {
                return NotFound();

            }

            return View(delinquents);


        }
    }
}
