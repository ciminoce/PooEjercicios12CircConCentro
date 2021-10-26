using PooEjercicios12CircConCentro.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEjercicios12CircConCentro.Datos
{
    public class RepositorioCircunferencias
    {
        private List<Circunferencia> listaCircunferencias;
        private readonly string _archivo = Environment.CurrentDirectory + @"\Circunferecias.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\Circunferecias.bak";

        public RepositorioCircunferencias()
        {
            listaCircunferencias = new List<Circunferencia>();
            listaCircunferencias=LeerDatosDelArchivo();
        }
        public List<Circunferencia> GetLista()
        {
            return listaCircunferencias;
        }

        public int GetCantidad()
        {
            return listaCircunferencias.Count;
        }
        private List<Circunferencia> LeerDatosDelArchivo()
        {

            var lista = new List<Circunferencia>();

            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Circunferencia circunferencia = ConstruirCircunferencia(linea);
                    lista.Add(circunferencia);
                }
                lector.Close();

            }
            return lista;
        }

        private Circunferencia ConstruirCircunferencia(string linea)
        {
            //linea="10|10|10|1|1"
            var campos=linea.Split('|');
            return new Circunferencia()
            {
                Radio = int.Parse(campos[0]),
                Centro = new Punto()
                {
                    X = int.Parse(campos[1]),
                    Y = int.Parse(campos[2])
                },
                Relleno = (Color) int.Parse(campos[3]),
                Borde = (Borde) int.Parse(campos[4])
            };
        }


        public void Agregar(Circunferencia circunferencia)
        {
            //Agrego en Archivo
            GuardarEnArchivo(circunferencia);
            //Agrego en lista
            listaCircunferencias.Add(circunferencia);
        }

        private void GuardarEnArchivo(Circunferencia circunferencia)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            string linea = ConstruirLinea(circunferencia);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Circunferencia circunferencia)
        {
            return $"{circunferencia.Radio}|{circunferencia.Centro.X}|" +
                   $"{circunferencia.Centro.Y}|{circunferencia.Relleno.GetHashCode()}|" +
                   $"{circunferencia.Borde.GetHashCode()}";
        }

        public void Borrar(Circunferencia circunferencia)
        {
            BorrarRegistroEnArchivo(circunferencia);
            listaCircunferencias.Remove(circunferencia);
        }

        private void BorrarRegistroEnArchivo(Circunferencia circunferencia)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Circunferencia circEnArchivo = ConstruirCircunferencia(linea);
                if (!circEnArchivo.Equals(circunferencia))
                {
                    escritor.WriteLine(linea);
                }
            }

            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }

        public void Editar(Circunferencia circBuscada, Circunferencia circModificada)
        {
            EditarRegistroEnArchivo(circBuscada, circModificada);
            int index = listaCircunferencias.IndexOf(circBuscada);
            listaCircunferencias.RemoveAt(index);
            listaCircunferencias.Insert(index, circModificada);
        }

        private void EditarRegistroEnArchivo(Circunferencia circBuscada, Circunferencia circModificada)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var circEnArchivo = ConstruirCircunferencia(linea);
                if (circEnArchivo.Equals(circBuscada))
                {
                    linea = ConstruirLinea(circModificada);

                }
                escritor.WriteLine(linea);
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }





        public List<Punto> Filtrar()
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(Circunferencia circunferencia)
        {
            return listaCircunferencias.Contains(circunferencia);
        }

    }
}
