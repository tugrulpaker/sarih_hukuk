﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Sarih_Law.Models
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }

        public string Yazar { get; set; }
        public string Aciklama { get; set; }
        public string Kategori { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
        public Alan Alan { get; set; }





    }



}
