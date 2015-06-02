using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace blog_deneme.Veritabani
{
    public class Yorum
    {
        [Key]
        public int id { get; set; }
        public string Ad { get; set; }
        public string Email { get; set; }
        public DateTime Tarih { get; set; }
        public string Icerik { get; set; }
        public bool Onay { get; set; }

        public virtual Makale Makale { get; set; }
    }
}