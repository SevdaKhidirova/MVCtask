using Beryllium.DAL;
using Beryllium.ViewModels;


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            HomeViewModels hvm = new HomeViewModels()
            {
                sliderItems = db.SliderItems.ToList(),
                smallSliders = db.SmallSliders.ToList(),
                news = db.News.ToList(),
                testimonials = db.Testimonials.ToList(),
                iconTextAreas=db.IconTextAreas.ToList()
            };


            return View(hvm);
        }

        public IActionResult About()
        {
            return View();
        }
 
     
    
    }
}
