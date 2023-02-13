using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sarih_Law.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sarih_Law.Controllers
{
    public class Adminler : Controller
    {
        public List<Blog> c;
        public List<Iletisim> z;
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
                    _db.Add(p);
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
                    blg.Kategori = b.Kategori;
                    b.BlogImage = blg.BlogImage;
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
                        // blg.Yazar = b.Yazar;
                        blg.Kategori = b.Kategori;


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
                        //  blg.Yazar = b.Yazar;
                        blg.Kategori = b.Kategori;


                        _db.SaveChanges();
                    }



                }
                else if(blg.BlogImage !=null && fileobj == null)
                {
                    blg.Aciklama = b.Aciklama;
                    blg.Baslik = b.Baslik;
                    blg.Tarih = b.Tarih;
                    // blg.Yazar = b.Yazar;
                    blg.Kategori = b.Kategori;

                    b.BlogImage = blg.BlogImage;
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
    }
}
