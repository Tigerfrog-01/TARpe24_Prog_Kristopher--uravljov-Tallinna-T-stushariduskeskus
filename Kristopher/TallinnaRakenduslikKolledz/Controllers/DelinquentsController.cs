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
        private Delinquents delinquents { get; set; }



        public async Task<IActionResult> Index()
        {
           return View();

        }


        [HttpGet]

        public IActionResult Create()
        {
            return View(Index);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind
        ("ID,FirstName,LastName,Violation,Subject,CurrentSituations")] Delinquents delinquents)
        {
            if (ModelState.IsValid)
            {
                _context.Delinquents.Add(delinquents);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(delinquents);
        }


    }
}
