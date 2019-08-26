using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPanel.DAL;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Areas.PoloAdmin.Controllers
{
    [Area("PoloAdmin")]
    public class ServiceController : Controller
    {
        private AppDbContext _context;
        public ServiceController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Services);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Service service =await _context.Services.FindAsync(id);
            if (service == null) return NotFound();
            return View(service);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
     
        public async Task<IActionResult> Delete (int? id)
        {
            if (id == null) return NotFound();
            Service service =await _context.Services.FindAsync(id);
            if (service == null) return NotFound();

            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Service service =await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Service service =await _context.Services.FindAsync(id);
            if (service == null) return NotFound();
            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Service service)
        {
           // Service dbService = await _context.Services.FindAsync(id);
            if (!ModelState.IsValid)
            {
                return View(service);
            }

            _context.Entry(service).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            //dbService.Title = service.Title;
            //dbService.Description = service.Description;
            //dbService.IconField = service.IconField;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}