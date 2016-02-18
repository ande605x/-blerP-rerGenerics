using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public class Bananer
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public decimal Lager { get; set; }

        protected bool Equals(Bananer other)
        {
            return string.Equals(Navn, other.Navn) && Pris == other.Pris && Lager == other.Lager;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Bananer) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Navn != null ? Navn.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Pris.GetHashCode();
                hashCode = (hashCode*397) ^ Lager.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"Pris: {Pris}, Navn: {Navn}, Lager: {Lager}";
        }
    }
}
