using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sarih_Law.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sarih_Law.ViewComponents
{
    public class AboneOl : ViewComponent
    {
        public ApplicationDbContext _db;
        public AboneOl(ApplicationDbContext db)
        {
            _db = db;

        }

        [HttpGet]
        public IViewComponentResult Invoke()

        {

            return View();
        }
    }
}
