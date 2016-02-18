using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public class Pære : IBeregnDecimal, IComparable<Pære>
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public decimal Lager { get; set; }

        public decimal BeregnTotal()
        {
            return Pris*Lager;
        }


        public override bool Equals(object obj)
        {
            var p = obj as Pære;

            return this.Navn == p.Navn;
        }

        public override int GetHashCode()
        {
            return this.Navn.GetHashCode();
        }


        public int CompareTo(Pære other)
        {

            int navncomp = String.Compare(this.Navn, other.Navn);

            if (navncomp == 0)
            {
                return Decimal.Compare(this.Lager, other.Lager);
            }

            return navncomp;
            
        }


    }
}
