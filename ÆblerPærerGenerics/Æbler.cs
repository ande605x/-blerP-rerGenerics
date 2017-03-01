using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public class Æbler : IComparable<Æbler>
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public int Lager { get; set; }


        public override bool Equals(object obj)
        {
            Æbler æble = obj as Æbler;

            if (obj == null || GetType() != obj.GetType())
                return false;

            if ((this.Navn == æble.Navn) && (this.Pris == æble.Pris) && (this.Lager==æble.Lager))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.Navn.GetHashCode() ^ this.Pris.GetHashCode() ^ this.Lager.GetHashCode();
        }

        public int CompareTo(Æbler other)  //Søger først på pris, så navn, så lager
        {
            int NavnSammenlign = String.Compare(this.Navn, other.Navn);

            if (this.Pris < other.Pris)
                return -1;
            else if (this.Pris == other.Pris)
            {
                if (NavnSammenlign < 0)
                {
                    return -1;
                }
                else if (this.Navn == other.Navn)
                {
                    if (this.Lager < other.Lager)
                        return -1;
                    else if (this.Lager == other.Lager)
                        return 0;
                    else return 1;

                }
                else return -1;
            }
                
            else
                return -1;
        }


        private class sortLagerDecendingHelper : IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                if (x.Lager > y.Lager)
                    return 1;
                else if (x.Lager == y.Lager)
                    return 0;
                else
                    return -1;
            }
        }

        public static IComparer<Æbler> sortLagerDescending()
        {
            return new sortLagerDecendingHelper();
        }

        public override string ToString()
        {
            return "Navn: " + this.Navn + " Pris: " + this.Pris + " Lagerbeholdning: " + this.Lager;
        }

    }

}


