using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sarih_Law.Models;
using X.PagedList;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sarih_Law.Controllers
{
    public class Ictihat : Controller
    {
        public List<Ictihat> d;

        public ApplicationDbContext _db;
        public Ictihat(ApplicationDbContext db)

        {
            _db = db;
        }
        public IActionResult Index(int sayfa = 1)
        {
            var degerler = _db.Ictihatlers.OrderByDescending(x => x.Tarih).ToPagedList(sayfa, 6);
            return View(degerler);
        }
        public ActionResult IctihatDetay(int id) //Ictihat basliginin üstüne bastigimda id parametresiyle değer döndürüp beni IctihatDetay viewine aktaricak
        {
            var a = _db.Ictihatlers.Where(x => x.ID == id).ToList();
           
            return View(a);


        }
    }
}
