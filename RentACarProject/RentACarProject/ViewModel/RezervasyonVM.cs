using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACarProject.ViewModel
{
    public class RezervasyonVM //ViewModel
    {
        public Rezervasyonlar Rec { get; set; }//veritabanına kaydedilecek kısım

        //kullanıcıya gösterilecek ama veritabanına kaydedilmeyecek.
        public string AracModel { get; set; }
        public string AracMarka { get; set; }
        public string AracVitesTipi { get; set; }
        public string YakıtTipi { get; set; }
    }
}