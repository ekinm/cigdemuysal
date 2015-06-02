using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace blog_deneme.Veritabani
{
    public class Etiket
    {
        [Key]
        public int id { get; set; }
        public int Ad { get; set; }

        public virtual List<Makale> Makale { get; set; }
    }
}