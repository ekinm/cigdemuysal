using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;

namespace blog_deneme.Veritabani
{
    public class Makale
    {
        [Key]
        public int id { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        [DataType(DataType.Html)]
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public String Url { get; set; }

       
        public virtual List<Etiket> Etiket { get; set; }
        public virtual List<Yorum> Yorum { get; set; }
    }
}