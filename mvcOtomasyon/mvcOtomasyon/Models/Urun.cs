using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcOtomasyon.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
    }
}