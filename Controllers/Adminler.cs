using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sarih_Law.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sarih_Law.Controllers
{
    public class Adminler : Controller
    {
        public List<Blog> c;
        public List<Iletisim> z;
        public List<Alan> k;
        public ApplicationDbContext _db;
        public IWebHostEnvironment _iweb;
        public Adminler(ApplicationDbContext db, IWebHostEnvironment iweb)
        {
            _db = db;
            _iweb = iweb;
        }
        [Authorize]
        public IActionResult Index()
        {
            c = _db.Blogs.ToList();

            return View(c);

        }
        [Authorize]
        [HttpGet]
        public IActionResult YeniBlog()
        {
            List<SelectListItem> degerler = (from i in _db.Alans.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.AlanAdi,
                                                 Value = i.ID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();

        }
        [Authorize]
        [HttpPost]
        public IActionResult YeniBlog(IFormFile fileobj, Blog p)
        {
           
            var imgext = Path.GetExtension(fileobj.FileName);
                if (imgext == ".jpg" || imgext == ".jpeg" || imgext == ".png")
                {
                    var uploadimg = Path.Combine(_iweb.WebRootPath, "Image", fileobj.FileName);
                    var stream = new FileStream(uploadimg, FileMode.Create);
                    fileobj.CopyTo(stream);
                    stream.Close();
                    p.BlogImage = @"/Image/" + fileobj.FileName;
                var ktg = _db.Alans.Where(x => x.ID == p.Alan.ID).FirstOrDefault();
                p.Alan = ktg;
                
                    _db.Blogs.Add(p);
                    _db.SaveChanges();

                }
           
            return RedirectToAction("Index");

            //return View();

        }
        public IActionResult BlogSil(int id)
        {

            var b = _db.Blogs.Find(id);
            _db.Blogs.Remove(b);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public IActionResult BlogGetir(int id)
        {
            var bl = _db.Blogs.Find(id);
            List<SelectListItem> degerler = (from i in _db.Alans.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.AlanAdi,
                                                 Value = i.ID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
          
            return View("BlogGetir", bl);
          

        }

        public IActionResult BlogGuncelle(IFormFile fileobj, Blog b, string fname, int id)
        {
            if (ModelState.IsValid)
            {
               
                var blg = _db.Blogs.Find(b.ID);
                if (blg.BlogImage == null && fileobj==null)
                {
                  
                    blg.Aciklama = b.Aciklama;
                    blg.Baslik = b.Baslik;
                    blg.Tarih = b.Tarih;
                    // blg.Yazar = b.Yazar;
                    //blg.Alan = b.Alan;
                    blg.Kategori = b.Kategori;
                    b.BlogImage = blg.BlogImage;
                    var ktg = _db.Alans.Where(x => x.ID == b.Alan.ID).FirstOrDefault();
                    blg.Alan.ID = ktg.ID;
                    _db.SaveChanges();
                }
                else if(blg.BlogImage== null && fileobj != null)
                {
                    var imgext = Path.GetExtension(fileobj.FileName);
                    if (imgext == ".jpg" || imgext == ".jpeg" || imgext == ".png")
                    {
                        var uploadimg = Path.Combine(_iweb.WebRootPath, "Image", fileobj.FileName);
                        var stream = new FileStream(uploadimg, FileMode.Create);
                        fileobj.CopyTo(stream);
                        stream.Close();

                        blg.Aciklama = b.Aciklama;
                        blg.Baslik = b.Baslik;
                        blg.BlogImage = @"/Image/" + fileobj.FileName;
                        blg.Tarih = b.Tarih;
                        //blg.Alan = b.Alan;
                        // blg.Yazar = b.Yazar;
                        blg.Kategori = b.Kategori;
                        var ktg = _db.Alans.Where(x => x.ID == b.Alan.ID).FirstOrDefault();
                        blg.Alan.ID = ktg.ID;

                        _db.SaveChanges();
                    }

                }
                else if (blg.BlogImage != null && fileobj != null)
                {

                    var imgext = Path.GetExtension(fileobj.FileName);
                    if (imgext == ".jpg" || imgext == ".jpeg" || imgext == ".png")
                    {
                        var uploadimg = Path.Combine(_iweb.WebRootPath, "Image", fileobj.FileName);
                        var stream = new FileStream(uploadimg, FileMode.Create);
                        fileobj.CopyTo(stream);
                        stream.Close();

                        blg.Aciklama = b.Aciklama;
                        blg.Baslik = b.Baslik;
                        blg.BlogImage = @"/Image/" + fileobj.FileName;
                        blg.Tarih = b.Tarih;
                       // blg.Alan = b.Alan;
                        //  blg.Yazar = b.Yazar;
                        blg.Kategori = b.Kategori;
                        var ktg = _db.Alans.Where(x => x.ID == b.Alan.ID).FirstOrDefault();
                        blg.Alan.ID = ktg.ID;

                        _db.SaveChanges();
                    }



                }
                else if(blg.BlogImage !=null && fileobj == null)
                {
                    blg.Aciklama = b.Aciklama;
                    blg.Baslik = b.Baslik;
                    blg.Tarih = b.Tarih;
                    //blg.Alan = b.Alan;
                    // blg.Yazar = b.Yazar;
                    blg.Kategori = b.Kategori;

                    b.BlogImage = blg.BlogImage;
                    var ktg = _db.Alans.Where(x => x.ID == b.Alan.ID).FirstOrDefault();
                    blg.Alan = ktg;
                    _db.SaveChanges();

                }
            }
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = _db.Yorumlars.ToList();
            return View(yorumlar);

        }
        public IActionResult YorumSil(int id)
        {

            var b = _db.Yorumlars.Find(id);
            _db.Yorumlars.Remove(b);
            _db.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
        [Authorize]
        public IActionResult YorumGetir(int id)
        {
            var yr = _db.Yorumlars.Find(id);
            return View("YorumGetir", yr);

        }
        public IActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = _db.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            _db.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
        [Authorize]
        public IActionResult IletisimGoruntule()
        {
            z = _db.Iletisims.ToList();


            return View(z);

        }

        [Authorize]
        [HttpGet]
        public IActionResult YeniAlan()
        {
            return View();


        }

        [Authorize]
        [HttpPost]
        public IActionResult YeniAlan(Alan l)
        {
            _db.Add(l);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
        [Authorize]
        public IActionResult AlanGoruntule()
        {
            k = _db.Alans.ToList();
            return View(k);
        }
        [Authorize]
        public IActionResult AlanSil(int id)
        {
            
            var b = _db.Alans.Find(id);

            _db.Alans.Remove(b);
            
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public IActionResult AlanGetir(int id)
        {

            var al = _db.Alans.Find(id);

            return View("AlanGetir", al);


            
        }
        [Authorize]
        public IActionResult AlanGuncelle(Alan b)
        {

            var d = _db.Alans.Find(b.ID);
            d.AlanAdi = b.AlanAdi;
            _db.SaveChanges();
            return RedirectToAction("AlanGoruntule");


        }

        [Authorize]
        public IActionResult AboneGoruntule()
        {
            var a = _db.Aboneliks.ToList();


            return View(a);

        }
    }
}
