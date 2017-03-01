using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public class Pærer
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public decimal Lager { get; set; }


    public override string ToString()
    {
        return "Navn: " + this.Navn + " Pris: " + this.Pris + " Lagerbeholdning: " + this.Lager;
    }


    }

   
}
