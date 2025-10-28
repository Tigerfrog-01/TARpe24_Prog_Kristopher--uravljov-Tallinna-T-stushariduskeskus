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
            return View(await _context.Delinquents.ToListAsync());

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
                _context.Delinquents.Add(delinquents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(delinquents);
        }


    }
}
