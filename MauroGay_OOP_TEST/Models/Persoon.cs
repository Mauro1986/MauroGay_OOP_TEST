using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauroGay_OOP_TEST.Models;

namespace MauroGay_OOP_TEST.Models
{
    public class Persoon
    {
        public Adress Adress { get; set; }             //_Adress juiste benaming?
        public string FamilieNaam { get; set; }
        public string VoorNaam { get; set; }

        private string naam;

        public string Naam          //voornaam + familienaam = Naam is niet gelukt
        {
            get { return naam; }
            set {
                naam = value; }
        }

        public Persoon(string voornaam, string familienaam)
        {
            VoorNaam = voornaam;
            FamilieNaam = familienaam;
            //Adress = adress;
        }
    }
}