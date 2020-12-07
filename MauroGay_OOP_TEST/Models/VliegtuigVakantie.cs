using System;

namespace MauroGay_OOP_TEST.Models
{
    public class VliegtuigVakantie : Reis
    {
        public int VliegtuigTicketPrijs { get; set; }

        public VliegtuigVakantie(DateTime terugkeerDatum, DateTime vertrekDatum, int aantalPersonen, int vliegtuigTicketPrijs) : base(terugkeerDatum, vertrekDatum, aantalPersonen)
        {
            VliegtuigTicketPrijs = vliegtuigTicketPrijs;
        }

        public  VliegtuigVakantie()         //error omwille van zelfde naam...
        { }

        public override double BerekenPrijs()
        {     
                return base.BerekenPrijs() + (VliegtuigTicketPrijs * AantalPersonen);
        }
    }
}