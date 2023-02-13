using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sarih_Law.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sarih_Law.Controllers
{
    public class Bloglar : Controller
    {
        public List<Blog> d;
        public ApplicationDbContext _db;
        public Bloglar(ApplicationDbContext db)
        {
            _db = db;
        }
        BlogYorum by = new BlogYorum();
        public IActionResult Index()
        {
            by.Deger1 = _db.Blogs.ToList();
            return View(by);
        }
        public ActionResult BlogDetay(int id) //Blog basliginin üstüne bastigimda id parametresiyle değer döndürüp beni detayblog viewine aktaricak
        {
            by.Deger1 = _db.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = _db.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);


        }
        
           
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> YorumYap(Yorumlar y)
        {

            _db.Yorumlars.Add(y);
            await _db.SaveChangesAsync();
            return Redirect("/");
        }
    }
}
