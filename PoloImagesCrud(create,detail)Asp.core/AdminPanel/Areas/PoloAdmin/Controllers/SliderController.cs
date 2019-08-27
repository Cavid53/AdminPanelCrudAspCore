using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AdminPanel.DAL;
using AdminPanel.Extentions;
using AdminPanel.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace AdminPanel.Areas.PoloAdmin.Controllers
{
    [Area("PoloAdmin")]
    public class SliderController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _env;
        public SliderController(AppDbContext context,IHostingEnvironment env)
        {
            this._context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders);
            
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Title"].ValidationState == ModelValidationState.Invalid || 
                ModelState["Description"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Content type must be image");
                return View();
            }

            if (!slider.Photo.CheckImageSize(2))
            {
                ModelState.AddModelError("Photo", "Image size not more than 2MB");
                return View();
            }
            string fileName = await slider.Photo.CopyImage(_env.WebRootPath, "sliders");


            slider.Image = fileName;

            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult>  Detail(int? id)
        {

            if (id == null) return NotFound();

            Slider slider = await _context.Sliders.FindAsync(id);

            if (slider == null) return NotFound();

            return View(slider);
        }
    }
}