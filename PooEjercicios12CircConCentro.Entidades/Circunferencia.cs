using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEjercicios12CircConCentro.Entidades
{
    public class Circunferencia:ICloneable
    {
        public Punto Centro { get; set; }
        public int Radio { get; set; }
        public Color Relleno { get; set; }
        public Borde Borde { get; set; }

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Circunferencia))
            {
                return false;
            }

            return this.Radio == ((Circunferencia) obj).Radio &&
                   this.Centro.Equals(((Circunferencia) obj).Centro) &&
                   this.Relleno == ((Circunferencia) obj).Relleno &&
                   this.Borde == ((Circunferencia) obj).Borde;
        }

        public override int GetHashCode()
        {
            return Radio.GetHashCode() + Centro.GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
