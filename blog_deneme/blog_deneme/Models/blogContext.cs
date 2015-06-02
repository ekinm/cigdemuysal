using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace blog_deneme.Veritabani
{
    public class blogContext :DbContext
    {
        public DbSet<Etiket> Etiket { get; set; }

        public DbSet<Yorum> Yorum { get; set; }
    
        public DbSet<Makale> Makale { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
     
    }
}