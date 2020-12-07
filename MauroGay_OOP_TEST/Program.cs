using System;
using MauroGay_OOP_TEST.Models;

namespace MauroGay_OOP_TEST
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Cruise1
            Cruise cruise1 = new Cruise(new DateTime(2030, 12, 24), new DateTime(2030, 12, 14), 2, true);

            Console.WriteLine($"Naam reis: cruise1 \nVertrek: {cruise1.VertrekDatum}" +
                $"\nTerugkeer:{cruise1.TerugkeerDatum}\nVip: {cruise1.Vip}\nPrijs: {cruise1.BerekenPrijs()}");

            Console.WriteLine("-------------------------------------------------");
            #endregion

            #region vliegtuigVakantie1
            VliegtuigVakantie vliegtuigVakantie1 = new VliegtuigVakantie(new DateTime(2022, 6, 14), new DateTime(2022, 6, 04), 4, 250);

            Console.WriteLine($"Naam reis: vliegtuigVakantie1 \nVertrek: {vliegtuigVakantie1.VertrekDatum}" +
                $"\nTerugkeer:{vliegtuigVakantie1.TerugkeerDatum}\nVliegtuig Ticket Prijs: {vliegtuigVakantie1.VliegtuigTicketPrijs}\nPrijs: {vliegtuigVakantie1.BerekenPrijs()}");

            Console.WriteLine("-------------------------------------------------");
            #endregion

            #region autoVakantie1
            AutoVakantie autoVakantie1 = new AutoVakantie(new DateTime(2040, 01, 11), new DateTime(2040, 01, 1), 12);

            Console.WriteLine($"Naam reis: autoVakantie1 \nVertrek: {autoVakantie1.VertrekDatum}" +
                $"\nTerugkeer:{autoVakantie1.TerugkeerDatum}\nEigen wagen: {autoVakantie1.EigenWagen}\nPrijs: {autoVakantie1.BerekenPrijs()}");

            Console.WriteLine("-------------------------------------------------");
            #endregion

            #region persoon1
            Persoon persoon1 = new Persoon("Mauro", "G");
            Console.WriteLine($"persoon1" +
                $"Voornaam: {persoon1.VoorNaam}\n" +
               $"Familienaam: {persoon1.FamilieNaam}\n");

            Console.WriteLine("-------------------------------------------------");
            #endregion

            #region adress1
            Adress adress1 = new Adress(3080, "Tervuren", "Brusselsesteenweg", "66");
            Console.WriteLine($"adress1\n" +
           $"Postcode: {adress1.Postcode}\n" +
           $"Gemeente: {adress1.Gemeente}\n" +
           $"Straat: {adress1.Straat}\n" +
           $"Huisnummer: {adress1.HuisNr}\n");

            Console.WriteLine("-------------------------------------------------");
            #endregion

            #region reservatie1
            ReisReservatie reservatie1 = new ReisReservatie();
            reservatie1.Reis = cruise1;
            //reservatie1.Reisbureau.Naam = "Neckerman";            // werkt niet
            //reservatie1.Reisbureau.Adres.Postcode = 2000;
            //reservatie1.Reisbureau.Adres.Gemeente = "Antwaarpe";
            //reservatie1.Reisbureau.Adres.Straat = "Meir";
            //reservatie1.Reisbureau.Adres.HuisNr = "111";
            //reservatie1.Persoon.VoorNaam = "Kenan";
            //reservatie1.Persoon.FamilieNaam = "Kurda";
            //reservatie1.Persoon.Adress.Postcode = 9000;
            //reservatie1.Persoon.Adress.Gemeente = "Gent";
            //reservatie1.Persoon.Adress.Straat = "DeGentstraat";
            //reservatie1.Persoon.Adress.HuisNr = "101";

            // Console.WriteLine(reservatie1.Reis);              //werkt niet
            //+reservatie1.Reisbureau.Naam
            // +
            //reservatie1.Reisbureau.Adres.Postcode +
            //reservatie1.Reisbureau.Adres.Gemeente +
            //reservatie1.Reisbureau.Adres.Straat +
            //reservatie1.Reisbureau.Adres.HuisNr +
            //reservatie1.Persoon.VoorNaam +
            //reservatie1.Persoon.FamilieNaam +
            //reservatie1.Persoon.Adress.Postcode +
            //reservatie1.Persoon.Adress.Gemeente +
            //reservatie1.Persoon.Adress.Straat +
            //reservatie1.Persoon.Adress.HuisNr
            #endregion
        }
    }
}