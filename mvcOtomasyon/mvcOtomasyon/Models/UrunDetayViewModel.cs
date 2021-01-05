using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Documents;

namespace mvcOtomasyon.Models
{
    public class UrunDetayViewModel
    {
        public Urun Urun { get; set; }
        public List UrunResimleri { get; set; }
    }
}