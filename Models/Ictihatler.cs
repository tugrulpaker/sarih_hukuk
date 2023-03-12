using System;
using System.ComponentModel.DataAnnotations;

namespace Sarih_Law.Models
{
    public class Ictihatler
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
