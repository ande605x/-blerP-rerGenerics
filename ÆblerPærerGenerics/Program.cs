using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varebeholdning af Æbler

            var æbleBeholdning = new List<Æbler>();
            æbleBeholdning.Add(new Æbler() { Navn = "Ingrid Marie", Lager = 50, Pris = 20.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Cox Orange", Lager = 25, Pris = 10.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Gråsten", Lager = 10, Pris = 22.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Guldborg", Lager = 100, Pris = 9.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 4, Pris = 5.0M });



            var pærerBeholdning = new List<Pærer>();
            pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 75M, Pris = 5M });
            pærerBeholdning.Add(new Pærer() { Navn = "Concorde", Lager = 33M, Pris = 12M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            pærerBeholdning.Add(new Pærer() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            pærerBeholdning.Add(new Pærer() { Navn = "Tongre", Lager = 7M, Pris = 21M });


            decimal værdiTotalÆbler = FrugtHandler.CalculateSumÆbler(æbleBeholdning);
            Console.WriteLine("Så meget er æblebeholdningen værd : " + værdiTotalÆbler );

            decimal værdiTotalPærer = FrugtHandler.CalculateSumPærer(pærerBeholdning);
            Console.WriteLine("Så meget er pærerbeholdningen værd: " + værdiTotalPærer);




            // EQUALS

            var æble1 = new Æbler() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };
            var æble2 = new Æbler() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };
            Console.WriteLine("æble1 equals æble2: " + æble1.Equals(æble2));
            Æbler æble3 = æble2;
            Console.WriteLine("æble2 equals æble3: " + æble2.Equals(æble3));
            var æble4 = new Æbler() { Navn = "Cox Orange", Lager = 1, Pris = 25.0M };
            Console.WriteLine("æble1 equals æble4: " + æble1.Equals(æble4));

            Console.ReadLine();
        }
    }
}
