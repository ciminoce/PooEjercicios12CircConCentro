using System;
using System.CodeDom;
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
using Color = PooEjercicios12CircConCentro.Entidades.Color;

namespace PooEjercicios12CircConCentro.Windows
{
    public partial class FrmCircunferenciaEdit : Form
    {
        public FrmCircunferenciaEdit()
        {
            InitializeComponent();
        }

        private bool esEdicion = false;
        //private RepositorioCircunferencias repositorio;
        public Circunferencia GetCircunferencia()
        {
            return circunferencia;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //repositorio = new RepositorioCircunferencias();
            CargarDatosComboColores(ref ColoresComboBox);
            if (circunferencia != null)
            {
                esEdicion = true;
                RadioTextBox.Text = circunferencia.Radio.ToString();
                XTextBox.Text = circunferencia.Centro.X.ToString();
                YTextBox.Text = circunferencia.Centro.Y.ToString();
                if (circunferencia.Borde==Borde.Sólido)
                {
                    SolidoRadioButton.Checked = true;
                }else if (circunferencia.Borde==Borde.Rayas)
                {
                    RayasRadioButton.Checked = true;
                }
                else
                {
                    PuntosRadioButton.Checked = true;
                }

                ColoresComboBox.SelectedItem = circunferencia.Relleno;
            }
        }

        private void CargarDatosComboColores(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Color));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        Circunferencia circunferencia;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (circunferencia == null)
                {
                    circunferencia = new Circunferencia();
                }

                circunferencia.Radio = int.Parse(RadioTextBox.Text);
                circunferencia.Centro = new Punto()
                {
                    X = int.Parse(XTextBox.Text),
                    Y = int.Parse(YTextBox.Text)
                };
                circunferencia.Relleno =(Color) ColoresComboBox.SelectedItem;
                if (SolidoRadioButton.Checked)
                {
                    circunferencia.Borde = Borde.Sólido;
                }else if (PuntosRadioButton.Checked)
                {
                    circunferencia.Borde = Borde.Puntos;
                }
                else
                {
                    circunferencia.Borde = Borde.Rayas;
                }

                if (!RepositorioCircunferencias.GetInstancia().Existe(circunferencia))
                {
                    if (!esEdicion)
                    {
                        RepositorioCircunferencias.GetInstancia().Agregar(circunferencia);
                        MessageBox.Show("Registro Agregado!!!", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        DialogResult dr = MessageBox.Show("¿Ingresa otro registro?", "Pregunta", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dr == DialogResult.Yes)
                        {
                            InicializarControles();
                            circunferencia = null;
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;
                        }

                    }

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Circunferencia repetida!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    
                }
            }
        }

        private void InicializarControles()
        {
            XTextBox.Clear();
            YTextBox.Clear();
            RadioTextBox.Clear();
            ColoresComboBox.SelectedIndex = 0;
            SolidoRadioButton.Checked = true;
            XTextBox.Focus();
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!int.TryParse(XTextBox.Text, out int x))
            {
                esValido = false;
                errorProvider1.SetError(XTextBox,"Coord. X mal ingresada");
            }

            if (!int.TryParse(YTextBox.Text, out int y))
            {
                esValido = false;
                errorProvider1.SetError(YTextBox, "Coord.Y mal ingresada");

            }
            if (!int.TryParse(RadioTextBox.Text, out int radio))
            {
                esValido = false;
                errorProvider1.SetError(YTextBox, "Radio mal ingresado");

            }else if (radio<=0)
            {
                esValido = false;
                errorProvider1.SetError(RadioTextBox,"El radio debe ser mayor a 0");
            }

            return esValido;
        }

        public void SetCircunferencia(Circunferencia circ)
        {
            this.circunferencia = circ;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
