using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstExample.Models
{
    public class Uye
    {
        public int UyeId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }
    }
}