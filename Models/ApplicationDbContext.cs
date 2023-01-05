﻿using System;
using Microsoft.EntityFrameworkCore;

namespace Sarih_Law.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
           

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }

    }
}
