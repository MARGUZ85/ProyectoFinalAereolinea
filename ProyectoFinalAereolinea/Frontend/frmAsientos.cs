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
            if (tabControl1.TabPages.Contains(tabPage2))
                tabControl1.TabPages.Remove(tabPage2);

            panelRegreso.Enabled = false;
        }

        private void cboOrigen_SelectedIndexChanged(object sender, EventArgs e) { 
        
        }

        private void cboDestinoFinal_SelectedIndexChanged(object sender, EventArgs e) {
        
        }

        private void dtpSalida_ValueChanged(object sender, EventArgs e) {
        
        }

        private void cboHoraSalida_SelectedIndexChanged(object sender, EventArgs e) {
        
        }

        private void cboVueloRedondo_CheckedChanged(object sender, EventArgs e)
        {
            if (cboVueloRedondo.Checked)
            {
                if (!tabControl1.TabPages.Contains(tabPage2))
                {
                    tabControl1.TabPages.Add(tabPage2);
                }
                InicializarAsientosRegreso();

                DaoAsiento dao = new DaoAsiento();
                var asientosOcupadosRegreso = dao.ObtenerAsientosOcupadosRegreso();
                MarcarAsientosOcupadosRegreso(asientosOcupadosRegreso);

                panelRegreso.Enabled = true; 
            }
            else
            {
                if (tabControl1.TabPages.Contains(tabPage2))
                {
                    tabControl1.TabPages.Remove(tabPage2);
                }

                panelRegreso.Enabled = false; 
            }
        }

        private void cboRegresoOrigen_SelectedIndexChanged(object sender, EventArgs e) {
        
        }

        private void cboRegresoDestinofinal_SelectedIndexChanged(object sender, EventArgs e) {
        
        }

        private void dtpRegreso_ValueChanged(object sender, EventArgs e) { 
        
        }

        private void cboHoraRegreso_SelectedIndexChanged(object sender, EventArgs e) { 
        
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var seleccionadosIda = ObtenerAsientosSeleccionados(dtgAsientos);

            if (seleccionadosIda.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un asiento para el vuelo de ida.");
                return;
            }

            List<string> seleccionadosRegreso = new List<string>();

            if (cboVueloRedondo.Checked)
            {
                seleccionadosRegreso = ObtenerAsientosSeleccionados(dtgAsientosRegreso);
                if (seleccionadosRegreso.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar asientos para el vuelo de regreso.");
                    return;
                }
            }

            string origen = cboOrigen.SelectedItem?.ToString() ?? "";
            string destino = cboDestinoFinal.SelectedItem?.ToString() ?? "";
            DateTime fecha = dtpSalida.Value.Date;

            TimeSpan hora = TimeSpan.Zero;
            if (TimeSpan.TryParse(cboHoraSalida.SelectedItem?.ToString(), out TimeSpan parsedHora))
                hora = parsedHora;

            frmRegistro registro = new frmRegistro(seleccionadosIda, seleccionadosRegreso, origen, destino, fecha, hora);
            registro.Show();
            this.Hide();
        }
        private void dtgAsientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var celda = dtgAsientos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (celda.ReadOnly || celda.Style.BackColor == Color.Red || celda.Style.BackColor == Color.Gray)
                    return;

                if (celda.Style.BackColor == Color.Blue)
                {
                    celda.Style.BackColor = Color.LightGreen;
                }
                else
                {
                    int.TryParse(lblAdultos.Text, out adultos);
                    int.TryParse(lblMenores.Text, out menores);

                    int seleccionados = ObtenerAsientosSeleccionados(dtgAsientos).Count;
                    int totalPermitido = adultos + menores;

                    if (seleccionados < totalPermitido)
                    {
                        celda.Style.BackColor = Color.Blue;
                    }
                    else
                    {
                        MessageBox.Show($"Solo puede seleccionar hasta {totalPermitido} asientos (adultos + menores).");
                    }
                }
            }
        }

        private void dtgAsientosRegreso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var celda = dtgAsientosRegreso.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (celda.ReadOnly || celda.Style.BackColor == Color.Red || celda.Style.BackColor == Color.Gray)
                    return;

                if (celda.Style.BackColor == Color.Blue)
                {
                    celda.Style.BackColor = Color.LightGreen;
                }
                else
                {
                    int.TryParse(lblAdultos.Text, out adultos);
                    int.TryParse(lblMenores.Text, out menores);

                    int seleccionados = ObtenerAsientosSeleccionados(dtgAsientosRegreso).Count;
                    int totalPermitido = adultos + menores;

                    if (seleccionados < totalPermitido)
                    {
                        celda.Style.BackColor = Color.Blue;
                    }
                    else
                    {
                        MessageBox.Show($"Solo puede seleccionar hasta {totalPermitido} asientos (adultos + menores) para el regreso.");
                    }
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
                    if (ocupados.Contains(celda.Value?.ToString()))
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

        private void panel1_Paint(object sender, PaintEventArgs e) {

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

        private void panelRegreso_Paint(object sender, PaintEventArgs e) { }

        public List<string> ObtenerAsientosSeleccionados(DataGridView dgv)
        {
            List<string> seleccionados = new List<string>();

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Style.BackColor == Color.Blue)
                    {
                        seleccionados.Add(celda.Value?.ToString());
                    }
                }
            }

            return seleccionados;
        }

        private void lblAdultos_Click(object sender, EventArgs e) { }

        private void lblMenores_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void InicializarAsientosRegreso()
        {
            int filas = 10;
            int columnas = 7;
            dtgAsientosRegreso.ColumnCount = columnas;
            dtgAsientosRegreso.RowCount = filas;
            for (int i = 0; i < columnas; i++)
            {
                dtgAsientosRegreso.Columns[i].Width = 50;

                if (i == 3)
                {
                    dtgAsientosRegreso.Columns[i].HeaderText = "";
                    dtgAsientosRegreso.Columns[i].ReadOnly = true;
                    dtgAsientosRegreso.Columns[i].DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    char letra = (char)('A' + (i > 3 ? i - 1 : i));
                    dtgAsientosRegreso.Columns[i].HeaderText = letra.ToString();
                }
            }

            for (int fila = 0; fila < filas; fila++)
            {
                for (int col = 0; col < columnas; col++)
                {
                    if (col == 3)
                    {
                        dtgAsientosRegreso.Rows[fila].Cells[col].Style.BackColor = Color.Gray;
                        dtgAsientosRegreso.Rows[fila].Cells[col].ReadOnly = true;
                        dtgAsientosRegreso.Rows[fila].Cells[col].Value = "";
                    }
                    else
                    {
                        char letra = (char)('A' + (col > 3 ? col - 1 : col));
                        dtgAsientosRegreso.Rows[fila].Cells[col].Style.BackColor = Color.LightGreen;
                        dtgAsientosRegreso.Rows[fila].Cells[col].Value = $"{fila + 1}{letra}";
                    }
                }
            }
        }

        private void MarcarAsientosOcupadosRegreso(List<string> ocupados)
        {
            foreach (DataGridViewRow fila in dtgAsientosRegreso.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (ocupados.Contains(celda.Value?.ToString()))
                    {
                        celda.Style.BackColor = Color.Red;
                        celda.ReadOnly = true;
                    }
                }
            }
        }

        private void dtgAsientos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var cell = dtgAsientos.CurrentCell;
                dtgAsientos_CellContentClick(this, new DataGridViewCellEventArgs(cell.ColumnIndex, cell.RowIndex));
                e.Handled = true;
            }
        }

        private void dtgAsientosRegreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var cell = dtgAsientosRegreso.CurrentCell;
                dtgAsientosRegreso_CellContentClick(this, new DataGridViewCellEventArgs(cell.ColumnIndex, cell.RowIndex));
                e.Handled = true;
            }
        }

        private void btnAdultoMasRegreso_Click_1(object sender, EventArgs e)
        {
            adultos++;
            lblAdultosRegreso.Text = adultos.ToString();
        }

        private void btnAdultoMenosRegreso_Click_1(object sender, EventArgs e)
        {
            if (adultos > 1)
            {
                adultos--;
                lblAdultosRegreso.Text = adultos.ToString();
            }
        }

        private void btnMenoresMenosRegreso_Click_1(object sender, EventArgs e)
        {
            if (menores > 0)
            {
                menores--;
                lblMenoresRegreso.Text = menores.ToString();
            }
        }

        private void btnMenoresMasRegreso_Click_1(object sender, EventArgs e)
        {
            menores++;
            lblMenoresRegreso.Text = menores.ToString();
        }

        private void btnBebeMenosRegreso_Click_1(object sender, EventArgs e)
        {
            if (bebes > 0)
            {
                bebes--;
                lblBebesRegreso.Text = bebes.ToString();
            }
        }

        private void btnBebeMasRegreso_Click_1(object sender, EventArgs e)
        {
            bebes++;
            lblBebesRegreso.Text = bebes.ToString();
        }
    }
}
