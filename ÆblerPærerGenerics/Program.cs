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
            æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 6, Pris = 5.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 4, Pris = 7.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 4, Pris = 5.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 4, Pris = 5.0M });


            Console.WriteLine("FØR SORTERING");
            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine("Navn: "+item.Navn+" Pris: "+item.Pris);
            }

            æbleBeholdning.Sort();

            Console.WriteLine("EFTER SORTERING");
            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine("Navn: " + item.Navn + " Pris: " + item.Pris);
            }








            Console.WriteLine("FØR SORTERING PÅ LAGER");
            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine(item.ToString());
            }
            æbleBeholdning.Sort(Æbler.sortLagerDescending());
            Console.WriteLine("EFTER SORTERING PÅ LAGER");
            foreach (var item in æbleBeholdning)
            {
                Console.WriteLine(item.ToString());
            }






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
            var pære = new Pærer();
            Console.WriteLine("æble1 equals pære: " + æble1.Equals(pære));
            var æble5 = new Æbler() { Navn = "Golden Delicius", Lager = 22, Pris = 10.0M };
            Console.WriteLine("æble1 equals æble5: " + æble1.Equals(æble5));

            Console.WriteLine("æble1 referenceEquals æble2: "+ Object.ReferenceEquals(æble1, æble2));
            Console.WriteLine("æble2 referenceEquals æble3: "+ Object.ReferenceEquals(æble3, æble2));



            // PREDICATE OPGAVE:
            Console.WriteLine("------------------------------------");
            Console.WriteLine("PREDICATE OPGAVE");


            var pærerBeholdning2 = new List<Pærer>();
            pærerBeholdning2.Add(new Pærer() { Navn = "Tongre", Lager = 7M, Pris = 21M });
            pærerBeholdning2.Add(new Pærer() { Navn = "Conference", Lager = 75M, Pris = 5M });
            pærerBeholdning2.Add(new Pærer() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            pærerBeholdning2.Add(new Pærer() { Navn = "Glorød Williams", Lager = 20, Pris = 15M });
            pærerBeholdning2.Add(new Pærer() { Navn = "Glorød Williams", Lager = 20, Pris = 20M });
            pærerBeholdning2.Add(new Pærer() { Navn = "Glorød Williams", Lager = 17, Pris = 15M });
            pærerBeholdning2.Add(new Pærer() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            pærerBeholdning2.Add(new Pærer() { Navn = "Concorde", Lager = 33M, Pris = 12M });



            var listeStørreEnd15 = pærerBeholdning2.FindAll(x => x.Pris > 15);       
            foreach (var item in listeStørreEnd15)
            {
                Console.WriteLine(item.ToString());
            }
            //eller
            foreach (var item in pærerBeholdning2.FindAll(x => x.Pris > 15))
            {
                Console.WriteLine(item.ToString());
            }


            foreach (var item in pærerBeholdning2.FindAll(x => x.Navn== "Glorød Williams"))
            {
                Console.WriteLine(item.ToString());
            }


            
            Console.WriteLine(pærerBeholdning2.Find(x => x.Lager==33).ToString());

            Console.WriteLine(pærerBeholdning2.Find(x => x.Navn=="Glorød Williams").ToString());

            Console.WriteLine(pærerBeholdning2.Find(x => x.Navn.Contains("re")).ToString());


            Console.WriteLine("Efter removeAll:");
            pærerBeholdning2.RemoveAll(x => x.Lager * x.Pris <= 250);
            foreach (var item in pærerBeholdning2)
            {
                Console.WriteLine(item.ToString());
            }

            











            Console.ReadLine();
        }
    }
}
