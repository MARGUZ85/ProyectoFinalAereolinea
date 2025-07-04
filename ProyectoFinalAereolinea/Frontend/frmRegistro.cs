using ProyectoFinalAereolinea.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAereolinea
{
    public partial class frmRegistro : Form
    {
        private List<string> asientosSeleccionados = new List<string>();
        private int indiceActual = 0;
        private List<DaoUsuario> listaUsuarios = new List<DaoUsuario>();
        private DaoRegistro daoRegistro = new DaoRegistro();

        private string origen;
        private string destino;
        private DateTime fecha;
        private TimeSpan hora;

        public frmRegistro(List<string> seleccionadosIda, List<string> seleccionadosRegreso, string origen, string destino, DateTime fecha, TimeSpan hora)
        {
            InitializeComponent();

            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
            this.hora = hora;

            if (seleccionadosIda != null)
                asientosSeleccionados.AddRange(seleccionadosIda);

            if (seleccionadosRegreso != null)
                asientosSeleccionados.AddRange(seleccionadosRegreso);

            MostrarContador();
        }

        private void MostrarContador()
        {
            this.Text = $"Registro de pasajero {indiceActual + 1} de {asientosSeleccionados.Count}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor ingresa el nombre y apellido del pasajero.");
                return;
            }

            DaoUsuario usuario = new DaoUsuario
            {
                Nombre = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim(),
            };

            listaUsuarios.Add(usuario);
            indiceActual++;

            if (indiceActual < asientosSeleccionados.Count)
            {
                LimpiarCampos();
                MostrarContador();
            }
            else
            {
                daoRegistro.GuardarRegistro(listaUsuarios, asientosSeleccionados, origen, destino, fecha, hora);
                MessageBox.Show("Pasajeros registrados y boletos guardados correctamente.");

                frmTicket ticket = new frmTicket(listaUsuarios, asientosSeleccionados, origen, destino, fecha, hora);
                ticket.Show();

                this.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbEdad.SelectedIndex = -1;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) { 
        
        }
        private void txtApellido_TextChanged(object sender, EventArgs e) {
        
        }
        private void cmbEdad_SelectedIndexChanged(object sender, EventArgs e) {
        
        }
        private void button1_Click(object sender, EventArgs e) {
        
        }
        private void btnPagar_Click(object sender, EventArgs e) {
        
        }
        private void lblTotal_Click(object sender, EventArgs e) {
        
        }
    }
}
