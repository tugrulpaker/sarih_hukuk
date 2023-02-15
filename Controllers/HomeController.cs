using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sarih_Law.Models;

namespace Sarih_Law.Controllers
{
    public class HomeController : Controller
    {
        public List<Blog> c;

        public ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var blogs = _db.Blogs.Include(b => b.Alan).ToList();
            return View(blogs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
