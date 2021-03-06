using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PooEjercicios12CircConCentro.Datos;
using PooEjercicios12CircConCentro.Entidades;

namespace PooEjercicios12CircConCentro.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmCircunferenciaEdit frm = new FrmCircunferenciaEdit();
            frm.Text = "Agregar Circunferencia";
            DialogResult dr = frm.ShowDialog(this);

            //if (dr == DialogResult.OK)
            //{
            //    Circunferencia circ = frm.GetCircunferencia();
            //    if (repositorio.Existe(circ))
            //    {
            //        MessageBox.Show("Circunferencia existente...!!!");
            //        return;
            //    }
            //    repositorio.Agregar(circ);
            //    DataGridViewRow r = ConstruirFila();
            //    SetearFila(r, circ);
            //    AgregarFila(r);
            //}
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            lista = RepositorioCircunferencias.GetInstancia().GetLista();
            MostrarDatosGrilla();
        }

        private DataGridViewRow ConstruirFila()
        {
           var r= new DataGridViewRow();
                    r.CreateCells(dgvDatos);
                    return r;

        }
        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Circunferencia circ)
        {
            r.Cells[cmnPunto.Index].Value = circ.Centro;
            r.Cells[cmnRadio.Index].Value = circ.Radio;
            r.Cells[cmnBorde.Index].Value = circ.Borde;
            r.Cells[cmnRelleno.Index].Value = circ.Relleno;
            r.Cells[cmnPerimetro.Index].Value = circ.GetPerimetro();
            r.Cells[cmnSuperficie.Index].Value = circ.GetSuperficie();

            r.Tag = circ;

        }
        //private RepositorioCircunferencias repositorio;
        private List<Circunferencia> lista;
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int cantidadRegistros;
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //repositorio = new RepositorioCircunferencias();
            cantidadRegistros = RepositorioCircunferencias.GetInstancia().GetCantidad();
            if (cantidadRegistros>0)
            {
                RecargarGrilla();
            }
        }

        private void MostrarDatosGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var item in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r);

            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                Circunferencia circ = (Circunferencia)r.Tag;
                Circunferencia circCopia =(Circunferencia) circ.Clone();
                FrmCircunferenciaEdit frm = new FrmCircunferenciaEdit();
                frm.Text = "Editar Circunferencia";
                frm.SetCircunferencia(circCopia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    circCopia = frm.GetCircunferencia();
                    if (RepositorioCircunferencias.GetInstancia().Existe(circCopia))
                    {
                        SetearFila(r,circ);
                        MessageBox.Show("Circunferencia repetida!!");
                        return;
                    }
                    RepositorioCircunferencias.GetInstancia().Editar(circ,circCopia);
                    SetearFila(r, circCopia);
                }
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                Circunferencia circ = (Circunferencia)r.Tag;
                DialogResult dr =
                    MessageBox.Show($"¿Desea dar de baja la circunferencia de centro {circ.Centro} y radio {circ.Radio}?",
                    "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    RepositorioCircunferencias.GetInstancia().Borrar(circ);
                    dgvDatos.Rows.Remove(r);
                    MessageBox.Show("Registro borrado", "Confirmar Baja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }

            }
        }
    }
}
