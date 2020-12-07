using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauroGay_OOP_TEST.Models
{
    public class Adress
    {
        public int Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Straat { get; set; }
        public string HuisNr { get; set; }

        public Adress(int postcode, string gemeente, string straat, string huisnr)
        {
            Postcode = postcode;
            Gemeente = gemeente;
            Straat = straat;
            HuisNr = huisnr;
        }
    }
}