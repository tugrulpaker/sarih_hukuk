using System;
using Microsoft.AspNetCore.Mvc;
using Sarih_Law.Models;

namespace Sarih_Law.ViewComponents
{
    public class YorumYap:ViewComponent
    {
        public ApplicationDbContext _db;
        public YorumYap(ApplicationDbContext db)
        {
            _db = db;

        }



        [HttpGet]
        public IViewComponentResult Invoke(int id)

        {

            ViewBag.deger = id;



            return View();
        }

    }
}
