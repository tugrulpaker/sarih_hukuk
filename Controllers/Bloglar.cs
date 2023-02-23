using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sarih_Law.Models;
using X.PagedList.Mvc.Common;
using X.PagedList;



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
        public IActionResult Index(int sayfa=1)
        {

            // by.Deger1 = _db.Blogs.Include(b => b.Alan).ToList().ToPagedList(1,6);
            //return View(by);
            // var degerler = _db.Blogs.Include(b => b.Alan).ToList().ToPagedList(sayfa, 4);
            //int pageSize = 10;
            //int pageNumber = (page ?? 1);
            //var degerler = _db.Blogs.Include(b => b.Alan).OrderBy(b => b.Baslik).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            var degerler = _db.Blogs.Include(b => b.Alan).OrderByDescending(x => x.Tarih).ToPagedList(sayfa, 6);
            return View(degerler);
        }
        public ActionResult BlogDetay(int id) //Blog basliginin üstüne bastigimda id parametresiyle değer döndürüp beni detayblog viewine aktaricak
        {
            by.Deger1 = _db.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = _db.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);


        }
        
        public IActionResult AlanDetay(int alanId, int sayfaa=1)
        {
            var bloglar = _db.Blogs.Include(b => b.Alan).Where(b => b.Alan.ID == alanId).OrderByDescending(x=>x.Tarih).ToPagedList(sayfaa, 4);
            return View(bloglar);
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
