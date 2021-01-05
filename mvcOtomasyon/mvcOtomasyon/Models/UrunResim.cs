using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcOtomasyon.Models
{
    public class UrunResim
    {
        public int UrunResimId { get; set; }
        public int UrunId { get; set; }
        public string UrunResimAciklamasi { get; set; }
        public string UrunResimUrl { get; set; }
    }
}