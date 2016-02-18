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


            var pærerBeholdning = new List<Pære>();
            pærerBeholdning.Add(new Pære() { Navn = "Tongre", Lager = 7M, Pris = 21M });
            pærerBeholdning.Add(new Pære() { Navn = "Conference", Lager = 75M, Pris = 5M });
            pærerBeholdning.Add(new Pære() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            pærerBeholdning.Add(new Pære() { Navn = "Glorød Williams", Lager = 20, Pris = 15M });
            pærerBeholdning.Add(new Pære() { Navn = "Glorød Williams", Lager = 20, Pris = 20M });
            pærerBeholdning.Add(new Pære() { Navn = "Glorød Williams", Lager = 17, Pris = 15M });
            pærerBeholdning.Add(new Pære() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            pærerBeholdning.Add(new Pære() { Navn = "Concorde", Lager = 33M, Pris = 12M });


            Console.WriteLine("Antal pærer : " + pærerBeholdning.Count);

            //pærerBeholdning.Remove(new Pære() {Navn = "Glorød Williams", Lager = 17, Pris = 15M});

            Console.WriteLine("Antal pærer : " + pærerBeholdning.Count);

            //pærerBeholdning.Remove(new Pære() { Navn = "Glorød Williams", Lager = 17, Pris = 15M });

            pærerBeholdning.RemoveAll(x => x.Lager == 20M);

            Console.WriteLine("Antal pærer : " + pærerBeholdning.Count);



            //Console.WriteLine("Før sortering ");
            //foreach (var p in pærerBeholdning)
            //{
            //    Console.WriteLine(p.Navn + "  " + p.Lager);
            //}
            //pærerBeholdning.Sort();

            //Console.WriteLine("Efter sortering");
            //foreach (var p in pærerBeholdning)
            //{
            //    Console.WriteLine(p.Navn + "  " + p.Lager);
            //}


            Console.ReadLine();

            //Varebeholdning af Æble

            var æbleBeholdning = new List<Æble>();
            æbleBeholdning.Add(new Æble() { Navn = "Ingrid Marie", Lager = 50, Pris = 20.0M });
            æbleBeholdning.Add(new Æble() { Navn = "Cox Orange", Lager = 25, Pris = 12.0M });
            æbleBeholdning.Add(new Æble() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M });
            æbleBeholdning.Add(new Æble() { Navn = "Cox Orange", Lager = 19, Pris = 10.0M });
            æbleBeholdning.Add(new Æble() { Navn = "Cox Orange", Lager = 25, Pris = 10.0M });
            æbleBeholdning.Add(new Æble() { Navn = "Cox Orange", Lager = 21, Pris = 11.0M });
            æbleBeholdning.Add(new Æble() { Navn = "Cox Orange", Lager = 1, Pris = 8.0M });
            æbleBeholdning.Add(new Æble() { Navn = "Gråsten", Lager = 10, Pris = 22.0M });
            æbleBeholdning.Add(new Æble() { Navn = "Guldborg", Lager = 100, Pris = 9.0M });
            æbleBeholdning.Add(new Æble() { Navn = "LøgÆble", Lager = 4, Pris = 5.0M });



            //Test Equals reference 
            Æble æble1 = new Æble() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };
            Æble æble2 = new Æble() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };
            Æble æble3 = æble2;

            Console.WriteLine("{0} Reference Equals {1}: {2}\n", æble2, æble3, Object.ReferenceEquals(æble2, æble3));
            Console.WriteLine("{0} Reference Equals {1}: {2}\n", æble1, æble2, Object.ReferenceEquals(æble1, æble2));

            æbleBeholdning.Sort(Æble.sortPrisDecending());
            Console.WriteLine("Æble.sortPrisDecending()");
            Console.WriteLine("************************");
            foreach (var a in æbleBeholdning)
            {
                Console.WriteLine(a);
            }

            æbleBeholdning.Sort(Æble.sortPrisAscending());
            Console.WriteLine("Æble.sortPrisAscending()");
            Console.WriteLine("************************");
            foreach (var a in æbleBeholdning)
            {
                Console.WriteLine(a);
            }

            //Console.WriteLine("æble1 equals æble2: " + æble1.Equals(æble2));

            //Console.WriteLine("equals : " + æble3.Equals(æble2));


            //Console.WriteLine("Hashcode ævle 1: " + æble1.GetHashCode());
            //Console.WriteLine("Hashcode ævle 2: " + æble2.GetHashCode());


            //bool ligmed = æble1.Equals(æble2);
            //Console.WriteLine("er ævle 1 lig med ævle 2 : "+ ligmed);



            //decimal værdiTotalÆbler = FrugtHandler.BeregnGenericSumDecimal(æbleBeholdning);
            //Console.WriteLine("Så meget er æblebeholdningen værd : " + værdiTotalÆbler );

            //decimal værdiTotalPærer = FrugtHandler.BeregnGenericSumDecimal(pærerBeholdning);
            //Console.WriteLine("Så meget er pærerbeholdningen værd: " + værdiTotalPærer);

            //æbleBeholdning.Sort(Æble.sortPrisDecending());
            //foreach (var apple in æbleBeholdning)
            //{
            //    Console.WriteLine(apple);

            //}
            //Console.WriteLine("Sorteret");
            //Console.WriteLine("---------------------------");
            //æbleBeholdning.OrderByDescending(x => x.Navn );//Sort();
            //foreach (var apple in æbleBeholdning.OrderByDescending(x => x.Navn))
            //{
            //    Console.WriteLine( apple);

            //}



            Console.ReadLine();
        }
    }
}
