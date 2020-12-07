using System;

namespace MauroGay_OOP_TEST.Models
{
    public class Cruise : Reis
    {
        int CruisePrijsExtraDagKost = 10;

        public bool Vip { get; set; }

        public Cruise(DateTime terugkeerDatum, DateTime vertrekDatum, int aantalPersonen, bool vip) : base(terugkeerDatum, vertrekDatum, aantalPersonen)
        {
            Vip = vip;
        }

        public override double BerekenPrijs()
        {
            if (Vip == true)
            {
                return base.BerekenPrijs() + ((CruisePrijsExtraDagKost * 1.5) * AantalPersonen);
            }
            else
            {
                return base.BerekenPrijs() + (CruisePrijsExtraDagKost * AantalPersonen); ;
            }
        }
    }
}