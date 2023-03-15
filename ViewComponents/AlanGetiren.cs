using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sarih_Law.Models;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sarih_Law.ViewComponents
{
    public class AlanGetiren : ViewComponent
    {
        public ApplicationDbContext _db;
        public AlanGetiren(ApplicationDbContext db)
        {
            _db = db;

        }
        [HttpGet]
        public IViewComponentResult Invoke()

        {
            var alanlar = _db.Alans.ToList();
            return View(alanlar);
        }
    }
}
