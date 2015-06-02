using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace blog_deneme.Veritabani
{
    public class Kullanici
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Sifre { get; set; }


    }
}