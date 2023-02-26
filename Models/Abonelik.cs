using System;
using System.ComponentModel.DataAnnotations;

namespace Sarih_Law.Models
{
    public class Abonelik
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }


    }
}
