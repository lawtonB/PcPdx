using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PcPdx.Models;


namespace PcPdx.Controllers
{
    public class ShowsController : Controller
    {
        private PcPdxContext db = new PcPdxContext();
        public IActionResult Index()
        {
            return View(db.Shows.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Show show)
        {
            db.Shows.Add(show);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
