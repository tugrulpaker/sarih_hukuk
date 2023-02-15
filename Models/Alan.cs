using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sarih_Law.Models
{
    public class Alan
    {
        [Key]
        public int ID { get; set; }

        public string AlanAdi { get; set; }

        public ICollection<Blog> Blogs { get; set; }



    }
}
