using ProyectoFinalAereolinea.Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinalAereolinea
{
    public partial class frmTicket : Form
    {
        private List<DaoUsuario> pasajeros;
        private List<string> asientos;
        private string origen;
        private string destino;
        private DateTime fecha;
        private TimeSpan hora;

        public frmTicket(List<DaoUsuario> pasajeros, List<string> asientos, string origen, string destino, DateTime fecha, TimeSpan hora)
        {
            InitializeComponent();
            this.Load += frmTicket_Load;

            this.pasajeros = pasajeros;
            this.asientos = asientos;
            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
            this.hora = hora;
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            lblOrigen.Text = $"{origen}";
            lblDestino.Text = $"{destino}";
            lblFecha.Text = $"{fecha.ToShortDateString()}";
            lblHora.Text = $"{hora}";

            dgvPasajeros.Columns.Clear();
            dgvPasajeros.Columns.Add("Nombre", "Nombre");
            dgvPasajeros.Columns.Add("Asiento", "Asiento");

            for (int i = 0; i < pasajeros.Count; i++)
            {
                dgvPasajeros.Rows.Add(pasajeros[i].Nombre, asientos[i]);
            }
        }
    }
}
