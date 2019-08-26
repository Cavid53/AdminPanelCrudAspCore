using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPanel.DAL;
using AdminPanel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            HomeModel homeModel = new HomeModel {
                Sliders=_context.Sliders,
                RepeatDescriptions=_context.RepeatDescriptions,
                Welcomes=_context.Welcomes,
                WhatWeDos=_context.WhatWeDos,
                Services=_context.Services
            };
            return View(homeModel);
        }
    }
}