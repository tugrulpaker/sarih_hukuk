using System;
using System.ComponentModel.DataAnnotations;

namespace Sarih_Law.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
