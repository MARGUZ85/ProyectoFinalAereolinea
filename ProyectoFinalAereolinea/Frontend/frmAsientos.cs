using Org.BouncyCastle.Utilities;
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
    public partial class frmAsientos : Form
    {
        public frmAsientos()
        {
            InitializeComponent();
        }

        private void frmAsientos_Load(object sender, EventArgs e)
        {
            InicializarAsientos();

            DaoAsiento dao = new DaoAsiento();
            var asientosOcupados = dao.ObtenerAsientosOcupados();

            MarcarAsientosOcupados(asientosOcupados);
            panelRegreso.Visible = false; 
        }

        private void cboOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDestinoFinal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboHoraSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboVueloRedondo_CheckedChanged(object sender, EventArgs e)
        {
            panelRegreso.Visible = cboVueloRedondo.Checked;
        }

        private void cboRegresoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboRegresoDestinofinal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpRegreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboHoraRegreso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro(); 
            registro.Show(); 
            this.Hide();
        }


        private void dtgAsientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var celda = dtgAsientos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (celda.Style.BackColor == Color.LightGreen)
                {
                    celda.Style.BackColor = Color.Blue; 
                }
            }
        }

        private void InicializarAsientos()
        {
            int filas = 10;
            int columnas = 7; 
            dtgAsientos.ColumnCount = columnas;
            dtgAsientos.RowCount = filas;
            for (int i = 0; i < columnas; i++)
            {
                dtgAsientos.Columns[i].Width = 50;

                if (i == 3)
                {
                    dtgAsientos.Columns[i].HeaderText = ""; 
                    dtgAsientos.Columns[i].ReadOnly = true;
                    dtgAsientos.Columns[i].DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    char letra = (char)('A' + (i > 3 ? i - 1 : i)); 
                    dtgAsientos.Columns[i].HeaderText = letra.ToString();
                }
            }

            for (int fila = 0; fila < filas; fila++)
            {
                for (int col = 0; col < columnas; col++)
                {
                    if (col == 3)
                    {
                        dtgAsientos.Rows[fila].Cells[col].Style.BackColor = Color.Gray;
                        dtgAsientos.Rows[fila].Cells[col].ReadOnly = true;
                        dtgAsientos.Rows[fila].Cells[col].Value = ""; 
                    }
                    else
                    {
                        char letra = (char)('A' + (col > 3 ? col - 1 : col));
                        dtgAsientos.Rows[fila].Cells[col].Style.BackColor = Color.LightGreen;
                        dtgAsientos.Rows[fila].Cells[col].Value = $"{fila + 1}{letra}";
                    }
                }
            }
        }


        private void MarcarAsientosOcupados(List<string> ocupados)
        {
            foreach (DataGridViewRow fila in dtgAsientos.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (ocupados.Contains(celda.Value.ToString()))
                    {
                        celda.Style.BackColor = Color.Red;
                        celda.ReadOnly = true;
                    }
                }
            }
        }
        int adultos = 1;
        int menores = 0;
        int bebes = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdultoMas_Click(object sender, EventArgs e)
        {
            adultos++;
            lblAdultos.Text = adultos.ToString();
        }

        private void btnAdultoMenos_Click(object sender, EventArgs e)
        {
            if (adultos > 1)
            {
                adultos--;
                lblAdultos.Text = adultos.ToString();
            }
        }

        private void btnMenoresMas_Click(object sender, EventArgs e)
        {
            menores++;
            lblMenores.Text = menores.ToString();
        }

        private void btnMenoresMenos_Click(object sender, EventArgs e)
        {
            if (menores > 0)
            {
                menores--;
                lblMenores.Text = menores.ToString();
            }
        }

        private void btnBebeMas_Click(object sender, EventArgs e)
        {
            bebes++;
            lblBebes.Text = bebes.ToString();
        }

        private void btnBebeMenos_Click(object sender, EventArgs e)
        {
            if (bebes > 0)
            {
                bebes--;
                lblBebes.Text = bebes.ToString();
            }
        }

        private void panelRegreso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
