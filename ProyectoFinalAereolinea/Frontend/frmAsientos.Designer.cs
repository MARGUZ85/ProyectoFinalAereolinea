namespace ProyectoFinalAereolinea
{
    partial class frmAsientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgAsientos = new System.Windows.Forms.DataGridView();
            this.cboDestinoFinal = new System.Windows.Forms.ComboBox();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboVueloRedondo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRegreso = new System.Windows.Forms.DateTimePicker();
            this.cboRegresoDestinofinal = new System.Windows.Forms.ComboBox();
            this.cboRegresoOrigen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboHoraSalida = new System.Windows.Forms.ComboBox();
            this.cboHoraRegreso = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.panelRegreso = new System.Windows.Forms.Panel();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblBebes = new System.Windows.Forms.Label();
            this.lblMenores = new System.Windows.Forms.Label();
            this.btnAdultoMenos = new System.Windows.Forms.Button();
            this.btnAdultoMas = new System.Windows.Forms.Button();
            this.btnMenoresMenos = new System.Windows.Forms.Button();
            this.btnMenoresMas = new System.Windows.Forms.Button();
            this.btnBebeMenos = new System.Windows.Forms.Button();
            this.btnBebeMas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsientos)).BeginInit();
            this.panelRegreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgAsientos
            // 
            this.dtgAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAsientos.Location = new System.Drawing.Point(589, 122);
            this.dtgAsientos.Name = "dtgAsientos";
            this.dtgAsientos.RowHeadersWidth = 51;
            this.dtgAsientos.RowTemplate.Height = 24;
            this.dtgAsientos.Size = new System.Drawing.Size(531, 584);
            this.dtgAsientos.TabIndex = 0;
            this.dtgAsientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAsientos_CellContentClick);
            // 
            // cboDestinoFinal
            // 
            this.cboDestinoFinal.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestinoFinal.FormattingEnabled = true;
            this.cboDestinoFinal.Items.AddRange(new object[] {
            "Aguascalientes",
            "BajaCalifornia",
            "BajaCaliforniaSur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "CiudadDeMexico",
            "Coahuila",
            "Colima",
            "Durango",
            "EstadoDeMexico",
            "Guanajuato",
            "Guerrero",
            "Jalisco",
            "Michoacan",
            "Morelos",
            "Nayarit",
            "NuevoLeon",
            "Oaxaca",
            "Puebla",
            "Queretaro",
            "QuintanaRoo",
            "SanLuisPotosi",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Veracruz",
            "Yucatan",
            "Zacatecas"});
            this.cboDestinoFinal.Location = new System.Drawing.Point(236, 137);
            this.cboDestinoFinal.Name = "cboDestinoFinal";
            this.cboDestinoFinal.Size = new System.Drawing.Size(264, 31);
            this.cboDestinoFinal.TabIndex = 3;
            this.cboDestinoFinal.SelectedIndexChanged += new System.EventHandler(this.cboDestinoFinal_SelectedIndexChanged);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Font = new System.Drawing.Font("New Gulim", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalida.Location = new System.Drawing.Point(18, 233);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(246, 28);
            this.dtpSalida.TabIndex = 4;
            this.dtpSalida.ValueChanged += new System.EventHandler(this.dtpSalida_ValueChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(323, 709);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(154, 51);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(31, 111);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(82, 23);
            this.lblOrigen.TabIndex = 16;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(318, 111);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(148, 23);
            this.lblDestino.TabIndex = 17;
            this.lblDestino.Text = "Destino Final:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha De Salida:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(161, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hora de Regreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("New Gulim", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "ASIENTOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("New Gulim", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Datos del Vuelo";
            // 
            // cboVueloRedondo
            // 
            this.cboVueloRedondo.AutoSize = true;
            this.cboVueloRedondo.Location = new System.Drawing.Point(201, 354);
            this.cboVueloRedondo.Name = "cboVueloRedondo";
            this.cboVueloRedondo.Size = new System.Drawing.Size(124, 20);
            this.cboVueloRedondo.TabIndex = 23;
            this.cboVueloRedondo.Text = "Vuelo Redondo";
            this.cboVueloRedondo.UseVisualStyleBackColor = true;
            this.cboVueloRedondo.CheckedChanged += new System.EventHandler(this.cboVueloRedondo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha De Regreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Destino Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Origen:";
            // 
            // dtpRegreso
            // 
            this.dtpRegreso.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegreso.Location = new System.Drawing.Point(67, 113);
            this.dtpRegreso.Name = "dtpRegreso";
            this.dtpRegreso.Size = new System.Drawing.Size(361, 34);
            this.dtpRegreso.TabIndex = 26;
            this.dtpRegreso.ValueChanged += new System.EventHandler(this.dtpRegreso_ValueChanged);
            // 
            // cboRegresoDestinofinal
            // 
            this.cboRegresoDestinofinal.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegresoDestinofinal.FormattingEnabled = true;
            this.cboRegresoDestinofinal.Items.AddRange(new object[] {
            "Aguascalientes",
            "BajaCalifornia",
            "BajaCaliforniaSur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "CiudadDeMexico",
            "Coahuila",
            "Colima",
            "Durango",
            "EstadoDeMexico",
            "Guanajuato",
            "Guerrero",
            "Jalisco",
            "Michoacan",
            "Morelos",
            "Nayarit",
            "NuevoLeon",
            "Oaxaca",
            "Puebla",
            "Queretaro",
            "QuintanaRoo",
            "SanLuisPotosi",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Veracruz",
            "Yucatan",
            "Zacatecas"});
            this.cboRegresoDestinofinal.Location = new System.Drawing.Point(303, 42);
            this.cboRegresoDestinofinal.Name = "cboRegresoDestinofinal";
            this.cboRegresoDestinofinal.Size = new System.Drawing.Size(194, 31);
            this.cboRegresoDestinofinal.TabIndex = 25;
            this.cboRegresoDestinofinal.SelectedIndexChanged += new System.EventHandler(this.cboRegresoDestinofinal_SelectedIndexChanged);
            // 
            // cboRegresoOrigen
            // 
            this.cboRegresoOrigen.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegresoOrigen.FormattingEnabled = true;
            this.cboRegresoOrigen.Items.AddRange(new object[] {
            "Aguascalientes",
            "BajaCalifornia",
            "BajaCaliforniaSur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "CiudadDeMexico",
            "Coahuila",
            "Colima",
            "Durango",
            "EstadoDeMexico",
            "Guanajuato",
            "Guerrero",
            "Jalisco",
            "Michoacan",
            "Morelos",
            "Nayarit",
            "NuevoLeon",
            "Oaxaca",
            "Puebla",
            "Queretaro",
            "QuintanaRoo",
            "SanLuisPotosi",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Veracruz",
            "Yucatan",
            "Zacatecas"});
            this.cboRegresoOrigen.Location = new System.Drawing.Point(32, 42);
            this.cboRegresoOrigen.Name = "cboRegresoOrigen";
            this.cboRegresoOrigen.Size = new System.Drawing.Size(194, 31);
            this.cboRegresoOrigen.TabIndex = 24;
            this.cboRegresoOrigen.SelectedIndexChanged += new System.EventHandler(this.cboRegresoOrigen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Hora de Salida:";
            // 
            // cboHoraSalida
            // 
            this.cboHoraSalida.FormattingEnabled = true;
            this.cboHoraSalida.Location = new System.Drawing.Point(284, 233);
            this.cboHoraSalida.Name = "cboHoraSalida";
            this.cboHoraSalida.Size = new System.Drawing.Size(249, 24);
            this.cboHoraSalida.TabIndex = 32;
            this.cboHoraSalida.SelectedIndexChanged += new System.EventHandler(this.cboHoraSalida_SelectedIndexChanged);
            // 
            // cboHoraRegreso
            // 
            this.cboHoraRegreso.FormattingEnabled = true;
            this.cboHoraRegreso.Location = new System.Drawing.Point(108, 187);
            this.cboHoraRegreso.Name = "cboHoraRegreso";
            this.cboHoraRegreso.Size = new System.Drawing.Size(249, 24);
            this.cboHoraRegreso.TabIndex = 33;
            this.cboHoraRegreso.SelectedIndexChanged += new System.EventHandler(this.cboHoraRegreso_SelectedIndexChanged);
            // 
            // cboOrigen
            // 
            this.cboOrigen.Font = new System.Drawing.Font("New Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "Aguascalientes",
            "BajaCalifornia",
            "BajaCaliforniaSur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "CiudadDeMexico",
            "Coahuila",
            "Colima",
            "Durango",
            "EstadoDeMexico",
            "Guanajuato",
            "Guerrero",
            "Jalisco",
            "Michoacan",
            "Morelos",
            "Nayarit",
            "NuevoLeon",
            "Oaxaca",
            "Puebla",
            "Queretaro",
            "QuintanaRoo",
            "SanLuisPotosi",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Veracruz",
            "Yucatan",
            "Zacatecas"});
            this.cboOrigen.Location = new System.Drawing.Point(12, 137);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(194, 31);
            this.cboOrigen.TabIndex = 34;
            this.cboOrigen.SelectedIndexChanged += new System.EventHandler(this.cboOrigen_SelectedIndexChanged);
            // 
            // panelRegreso
            // 
            this.panelRegreso.Controls.Add(this.label12);
            this.panelRegreso.Controls.Add(this.label13);
            this.panelRegreso.Controls.Add(this.label14);
            this.panelRegreso.Controls.Add(this.button1);
            this.panelRegreso.Controls.Add(this.button2);
            this.panelRegreso.Controls.Add(this.button3);
            this.panelRegreso.Controls.Add(this.button4);
            this.panelRegreso.Controls.Add(this.button5);
            this.panelRegreso.Controls.Add(this.button6);
            this.panelRegreso.Controls.Add(this.label15);
            this.panelRegreso.Controls.Add(this.label16);
            this.panelRegreso.Controls.Add(this.label17);
            this.panelRegreso.Controls.Add(this.label10);
            this.panelRegreso.Controls.Add(this.dtpRegreso);
            this.panelRegreso.Controls.Add(this.label2);
            this.panelRegreso.Controls.Add(this.label1);
            this.panelRegreso.Controls.Add(this.label3);
            this.panelRegreso.Controls.Add(this.cboHoraRegreso);
            this.panelRegreso.Controls.Add(this.cboRegresoDestinofinal);
            this.panelRegreso.Controls.Add(this.cboRegresoOrigen);
            this.panelRegreso.Location = new System.Drawing.Point(12, 380);
            this.panelRegreso.Name = "panelRegreso";
            this.panelRegreso.Size = new System.Drawing.Size(562, 298);
            this.panelRegreso.TabIndex = 35;
            this.panelRegreso.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegreso_Paint);
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(55, 305);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(14, 16);
            this.lblAdultos.TabIndex = 36;
            this.lblAdultos.Text = "1";
            // 
            // lblBebes
            // 
            this.lblBebes.AutoSize = true;
            this.lblBebes.Location = new System.Drawing.Point(419, 303);
            this.lblBebes.Name = "lblBebes";
            this.lblBebes.Size = new System.Drawing.Size(14, 16);
            this.lblBebes.TabIndex = 37;
            this.lblBebes.Text = "0";
            // 
            // lblMenores
            // 
            this.lblMenores.AutoSize = true;
            this.lblMenores.Location = new System.Drawing.Point(220, 305);
            this.lblMenores.Name = "lblMenores";
            this.lblMenores.Size = new System.Drawing.Size(14, 16);
            this.lblMenores.TabIndex = 38;
            this.lblMenores.Text = "0";
            // 
            // btnAdultoMenos
            // 
            this.btnAdultoMenos.Location = new System.Drawing.Point(12, 303);
            this.btnAdultoMenos.Name = "btnAdultoMenos";
            this.btnAdultoMenos.Size = new System.Drawing.Size(37, 20);
            this.btnAdultoMenos.TabIndex = 39;
            this.btnAdultoMenos.Text = "-";
            this.btnAdultoMenos.UseVisualStyleBackColor = true;
            this.btnAdultoMenos.Click += new System.EventHandler(this.btnAdultoMenos_Click);
            // 
            // btnAdultoMas
            // 
            this.btnAdultoMas.Location = new System.Drawing.Point(106, 301);
            this.btnAdultoMas.Name = "btnAdultoMas";
            this.btnAdultoMas.Size = new System.Drawing.Size(55, 23);
            this.btnAdultoMas.TabIndex = 40;
            this.btnAdultoMas.Text = "+";
            this.btnAdultoMas.UseVisualStyleBackColor = true;
            this.btnAdultoMas.Click += new System.EventHandler(this.btnAdultoMas_Click);
            // 
            // btnMenoresMenos
            // 
            this.btnMenoresMenos.Location = new System.Drawing.Point(165, 301);
            this.btnMenoresMenos.Name = "btnMenoresMenos";
            this.btnMenoresMenos.Size = new System.Drawing.Size(49, 24);
            this.btnMenoresMenos.TabIndex = 41;
            this.btnMenoresMenos.Text = "-";
            this.btnMenoresMenos.UseVisualStyleBackColor = true;
            this.btnMenoresMenos.Click += new System.EventHandler(this.btnMenoresMenos_Click);
            // 
            // btnMenoresMas
            // 
            this.btnMenoresMas.Location = new System.Drawing.Point(286, 300);
            this.btnMenoresMas.Name = "btnMenoresMas";
            this.btnMenoresMas.Size = new System.Drawing.Size(50, 23);
            this.btnMenoresMas.TabIndex = 42;
            this.btnMenoresMas.Text = "+";
            this.btnMenoresMas.UseVisualStyleBackColor = true;
            this.btnMenoresMas.Click += new System.EventHandler(this.btnMenoresMas_Click);
            // 
            // btnBebeMenos
            // 
            this.btnBebeMenos.Location = new System.Drawing.Point(356, 300);
            this.btnBebeMenos.Name = "btnBebeMenos";
            this.btnBebeMenos.Size = new System.Drawing.Size(55, 23);
            this.btnBebeMenos.TabIndex = 43;
            this.btnBebeMenos.Text = "-";
            this.btnBebeMenos.UseVisualStyleBackColor = true;
            this.btnBebeMenos.Click += new System.EventHandler(this.btnBebeMenos_Click);
            // 
            // btnBebeMas
            // 
            this.btnBebeMas.Location = new System.Drawing.Point(478, 298);
            this.btnBebeMas.Name = "btnBebeMas";
            this.btnBebeMas.Size = new System.Drawing.Size(55, 23);
            this.btnBebeMas.TabIndex = 44;
            this.btnBebeMas.Text = "+";
            this.btnBebeMas.UseVisualStyleBackColor = true;
            this.btnBebeMas.Click += new System.EventHandler(this.btnBebeMas_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Menores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Bebés";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Adultos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Menores";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(424, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "Bebés";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 57;
            this.label14.Text = "Adultos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 24);
            this.button4.TabIndex = 53;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(111, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 23);
            this.button5.TabIndex = 52;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 245);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 20);
            this.button6.TabIndex = 51;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(424, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 16);
            this.label16.TabIndex = 49;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(60, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 16);
            this.label17.TabIndex = 48;
            this.label17.Text = "1";
            // 
            // frmAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 784);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBebeMas);
            this.Controls.Add(this.btnBebeMenos);
            this.Controls.Add(this.btnMenoresMas);
            this.Controls.Add(this.btnMenoresMenos);
            this.Controls.Add(this.btnAdultoMas);
            this.Controls.Add(this.btnAdultoMenos);
            this.Controls.Add(this.lblMenores);
            this.Controls.Add(this.lblBebes);
            this.Controls.Add(this.lblAdultos);
            this.Controls.Add(this.panelRegreso);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.cboHoraSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboVueloRedondo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.cboDestinoFinal);
            this.Controls.Add(this.dtgAsientos);
            this.Name = "frmAsientos";
            this.Text = "frmAsientos";
            this.Load += new System.EventHandler(this.frmAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsientos)).EndInit();
            this.panelRegreso.ResumeLayout(false);
            this.panelRegreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAsientos;
        private System.Windows.Forms.ComboBox cboDestinoFinal;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cboVueloRedondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRegreso;
        private System.Windows.Forms.ComboBox cboRegresoDestinofinal;
        private System.Windows.Forms.ComboBox cboRegresoOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboHoraSalida;
        private System.Windows.Forms.ComboBox cboHoraRegreso;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Panel panelRegreso;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Label lblBebes;
        private System.Windows.Forms.Label lblMenores;
        private System.Windows.Forms.Button btnAdultoMenos;
        private System.Windows.Forms.Button btnAdultoMas;
        private System.Windows.Forms.Button btnMenoresMenos;
        private System.Windows.Forms.Button btnMenoresMas;
        private System.Windows.Forms.Button btnBebeMenos;
        private System.Windows.Forms.Button btnBebeMas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}