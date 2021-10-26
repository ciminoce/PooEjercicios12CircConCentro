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
        private ManejadorDeArchivos manejador;
        private static RepositorioCircunferencias _instancia = null;

        public static RepositorioCircunferencias GetInstancia()
        {
            if (_instancia==null)
            {
                _instancia = new RepositorioCircunferencias();
            }

            return _instancia;
        }

        private RepositorioCircunferencias()
        {
            listaCircunferencias = new List<Circunferencia>();
            manejador = new ManejadorDeArchivos();
            listaCircunferencias=manejador.LeerDatosDelArchivo();
        }
        public List<Circunferencia> GetLista()
        {
            return listaCircunferencias;
        }

        public int GetCantidad()
        {
            return listaCircunferencias.Count;
        }


        public void Agregar(Circunferencia circunferencia)
        {
            //Agrego en Archivo
            manejador.GuardarEnArchivo(circunferencia);
            //Agrego en lista
            listaCircunferencias.Add(circunferencia);
        }


        public void Borrar(Circunferencia circunferencia)
        {
            manejador.BorrarRegistroEnArchivo(circunferencia);
            listaCircunferencias.Remove(circunferencia);
        }

        public void Editar(Circunferencia circBuscada, Circunferencia circModificada)
        {
            manejador.EditarRegistroEnArchivo(circBuscada, circModificada);
            int index = listaCircunferencias.IndexOf(circBuscada);
            listaCircunferencias.RemoveAt(index);
            listaCircunferencias.Insert(index, circModificada);
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
