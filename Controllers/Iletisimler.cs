using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sarih_Law.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sarih_Law.Controllers
{
    public class Iletisimler : Controller
    {
        // GET: /<controller>/
        public List<Iletisim> d;

        public ApplicationDbContext _db;
        public Iletisimler(ApplicationDbContext db)

        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }


        // GET: /<controller>/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BizeUlas(Iletisim p)

        {
            _db.Iletisims.Add(p);
            await _db.SaveChangesAsync();
            return Redirect("/");
        }

      
    }
}
