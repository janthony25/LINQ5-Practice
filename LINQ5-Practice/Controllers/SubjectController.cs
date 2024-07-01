using LINQ5_Practice.Data;
using LINQ5_Practice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LINQ5_Practice.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SubjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var subjectList = _context.tblSubject.ToList();
            return View(subjectList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubjectName", "SubjectUnit", "CourseId")]tblSubject subject)
        {
            if(ModelState.IsValid)
            {
                _context.tblSubject.Add(subject);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(subject);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var subject = _context.tblSubject.FirstOrDefault(s => s.SubjectId == id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        //WORKING EDIT POST
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("SubjectId,SubjectName,SubjectUnit,CourseId")] tblSubject subject)
        {
            if (ModelState.IsValid)
            {
                _context.Update(subject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }
            
        }
    }

