using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public class Æble:IBeregnDecimal,IComparable<Æble>
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public int Lager { get; set; }

        public decimal BeregnTotal()
        {
            return Pris * Lager;
        }

        public int CompareTo(Æble other)
        {

            //return String.Compare(this.Navn, other.Navn);

            int a = String.Compare(this.Navn, other.Navn);

            if (a == 0)
            {
                int prisSammenligning = Decimal.Compare(this.Pris, other.Pris);
                if (prisSammenligning == 0)
                {
                    return this.Lager - other.Lager;

                }
                return prisSammenligning;
            }

            return a;
        }

        public override string ToString()
        {
            return Navn +" " + Pris.ToString() +" Lager: "+ Lager.ToString();
        }


        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Æble))
                return false;
            else
            {
                Æble other = obj as Æble;
                return this.Navn == other.Navn && this.Lager == other.Lager && this.Pris == other.Pris;

            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Navn != null ? Navn.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Pris.GetHashCode();
                hashCode = (hashCode * 397) ^ Lager.GetHashCode();
                return hashCode;
            }
        }

        private class sortPrisDecendingHelper : IComparer<Æble>
        {
            int IComparer<Æble>.Compare(Æble x, Æble y)
            {
                if (x.Pris < y.Pris)
                    return 1;
                if (x.Pris > y.Pris)
                    return -1;
                else
                    return 0;
            }
        }

        private class sortPrisAscendingHelper : IComparer<Æble>
        {
            int IComparer<Æble>.Compare(Æble x, Æble y)
            {
                if (x.Pris > y.Pris)
                    return 1;
                if (x.Pris < y.Pris)
                    return -1;
                else
                    return 0;
            }
        }


        public static IComparer<Æble> sortPrisDecending()
        {
            return new sortPrisDecendingHelper();
        }


        public static IComparer<Æble> sortPrisAscending()
        {
            return new sortPrisAscendingHelper();
        }

    }

}
