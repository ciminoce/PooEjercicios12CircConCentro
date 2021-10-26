using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEjercicios12CircConCentro.Entidades
{
    public class Punto
    {
        private Cuadrante cuadrante;
        public int X { get; set; }

        public int Y { get; set; }



        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Punto))
            {
                return false;
            }

            return this.X == ((Punto)obj).X && this.Y == ((Punto)obj).Y;
        }

        public override int GetHashCode()
        {
            return (X + Y).GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetCuadrante()
        {
            if (X >= 0 && Y >= 0)
            {
                cuadrante = Cuadrante.Primer_Cuadrante;
            }
            else if (X < 0 && Y > 0)
            {
                cuadrante = Cuadrante.Segundo_Cuadrante;
            }
            else if (X < 0 && Y < 0)
            {
                cuadrante = Cuadrante.Tercer_Cuadrante;
            }
            else
            {
                cuadrante = Cuadrante.Cuarto_Cuadrante;
            }

            var palabras = cuadrante.ToString().Split('_');
            return $"{palabras[0]} {palabras[1]}";
        }

        public double GetDistanciaAlOrigen()
        {
            throw new System.NotImplementedException();
        }

        public string GetCoordenadasPolares()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
