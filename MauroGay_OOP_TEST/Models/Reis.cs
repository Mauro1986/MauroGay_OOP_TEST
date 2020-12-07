using System;

namespace MauroGay_OOP_TEST.Models
{
    public abstract class Reis
    {
        private const double Basisdagprijs = 40;

        private int aantalDagen;
        public int AantalDagen
        {
            get { return aantalDagen = (int)(terugkeerDatum - vertrekDatum).TotalDays; }
        }

        public int AantalPersonen { get; set; }

        private DateTime terugkeerDatum;
        public DateTime TerugkeerDatum
        {
            get { return terugkeerDatum; }
            set
            {
                if ((value < DateTime.Now))
                {
                    Console.WriteLine("Terugkeerdatum kan niet in het verleden liggen");
                }
                //if (VertrekDatum.Date > TerugkeerDatum.Date)                                  //werkt niet
                //{
                //    Console.WriteLine("vertrekdatum kan niet voor terugkeerdatum liggen");
                //}
                else
                {
                    terugkeerDatum = value;
                }
            }
        }

        private DateTime vertrekDatum;
        public DateTime VertrekDatum
        {
            get { return vertrekDatum; }
            set
            {
                if (value < DateTime.Now)
                {
                    Console.WriteLine("Vertrekdatum kan niet in het verleden liggen");
                }

                else
                {
                    vertrekDatum = value;
                }
            }
        }

        public Reis(DateTime terugkeerDatum, DateTime vertrekDatum, int aantalPersonen)
        {
            TerugkeerDatum = terugkeerDatum;
            VertrekDatum = vertrekDatum;
            AantalPersonen = aantalPersonen;
        }

        protected Reis()
        {
        }

        public virtual double BerekenPrijs()
        {
            double prijs = AantalDagen * Basisdagprijs * AantalPersonen;
            return prijs;
        }
    }
}
