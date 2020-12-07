using System;

namespace MauroGay_OOP_TEST.Models
{
    public class AutoVakantie : Reis
    {
        int ExtraPrijsHuurAuto = 10;

        public bool EigenWagen { get; set; }

        public AutoVakantie(DateTime terugkeerDatum, DateTime vertrekDatum, int aantalPersonen) : base(terugkeerDatum, vertrekDatum, aantalPersonen)
        {
            EigenWagen = false;
        }

        public override double BerekenPrijs()
        {
            if (EigenWagen == false)
            {
                if (AantalPersonen <= 5)
                {
                    return base.BerekenPrijs() + (ExtraPrijsHuurAuto * AantalDagen);
                }
                else
                {
                    double aantalwagens = AantalPersonen / 5;
                    aantalwagens = ((int)Math.Ceiling(aantalwagens));
                    return base.BerekenPrijs() + ((ExtraPrijsHuurAuto * aantalwagens) * AantalDagen);
                }
            }
            else
            {
                return base.BerekenPrijs();
            }
        }
    }
}
