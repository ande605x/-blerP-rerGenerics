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


            decimal værdiTotalÆbler = FrugtHandler.BeregnGenericSumDecimal(æbleBeholdning);
            Console.WriteLine("Så meget er æblebeholdningen værd : " + værdiTotalÆbler );

            decimal værdiTotalPærer = FrugtHandler.BeregnGenericSumDecimal(pærerBeholdning);
            Console.WriteLine("Så meget er pærerbeholdningen værd: " + værdiTotalPærer);


            Console.ReadLine();
        }
    }
}
