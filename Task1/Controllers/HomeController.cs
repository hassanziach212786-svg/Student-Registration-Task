using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using Task1.Models;
using Task1.Models.dbcontext;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly stdcontext _context;
        public HomeController(ILogger<HomeController> logger, stdcontext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Registrations.ToList());
        }

        // CREATE - GET
        public IActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        public IActionResult Create(Stdform model)
        {
            _context.Registrations.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

       
        public IActionResult Edit(int id)
        {
            var data = _context.Registrations.Find(id);
            return View(data);
        }

      
        [HttpPost]
        public IActionResult Edit(Stdform model)
        {
            _context.Registrations.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var data = _context.Registrations.Find(id);
            _context.Registrations.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
      
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
