namespace Generador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvinfo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.btncambiar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbstatus = new MetroFramework.Controls.MetroComboBox();
            this.btngen = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnrefresj = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblcorreoD = new System.Windows.Forms.Label();
            this.btneliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblempresa = new System.Windows.Forms.Label();
            this.lblasesor = new System.Windows.Forms.Label();
            this.lblproyecto = new System.Windows.Forms.Label();
            this.lblcarrera = new System.Windows.Forms.Label();
            this.lblnombreD = new System.Windows.Forms.Label();
            this.lblctl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcontrol = new System.Windows.Forms.Label();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.txtbuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnacercaDe = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncambiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrefresj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnacercaDe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinfo
            // 
            this.dgvinfo.AllowUserToAddRows = false;
            this.dgvinfo.AllowUserToDeleteRows = false;
            this.dgvinfo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvinfo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvinfo.DoubleBuffered = true;
            this.dgvinfo.EnableHeadersVisualStyles = false;
            this.dgvinfo.HeaderBgColor = System.Drawing.Color.LightGray;
            this.dgvinfo.HeaderForeColor = System.Drawing.Color.DarkCyan;
            this.dgvinfo.Location = new System.Drawing.Point(506, 188);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvinfo.RowTemplate.Height = 28;
            this.dgvinfo.Size = new System.Drawing.Size(1356, 731);
            this.dgvinfo.TabIndex = 10;
            this.dgvinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinfo_CellClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.btncambiar);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.cbstatus);
            this.bunifuGradientPanel1.Controls.Add(this.btngen);
            this.bunifuGradientPanel1.Controls.Add(this.lblid);
            this.bunifuGradientPanel1.Controls.Add(this.label10);
            this.bunifuGradientPanel1.Controls.Add(this.label12);
            this.bunifuGradientPanel1.Controls.Add(this.label13);
            this.bunifuGradientPanel1.Controls.Add(this.btnrefresj);
            this.bunifuGradientPanel1.Controls.Add(this.lblcorreoD);
            this.bunifuGradientPanel1.Controls.Add(this.btneliminar);
            this.bunifuGradientPanel1.Controls.Add(this.lblcorreo);
            this.bunifuGradientPanel1.Controls.Add(this.label11);
            this.bunifuGradientPanel1.Controls.Add(this.lblempresa);
            this.bunifuGradientPanel1.Controls.Add(this.lblasesor);
            this.bunifuGradientPanel1.Controls.Add(this.lblproyecto);
            this.bunifuGradientPanel1.Controls.Add(this.lblcarrera);
            this.bunifuGradientPanel1.Controls.Add(this.lblnombreD);
            this.bunifuGradientPanel1.Controls.Add(this.lblctl);
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.lblnombre);
            this.bunifuGradientPanel1.Controls.Add(this.lblcontrol);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(23, 188);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(477, 731);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(18, 699);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Actualizar";
            // 
            // btncambiar
            // 
            this.btncambiar.BackColor = System.Drawing.Color.Transparent;
            this.btncambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncambiar.Image = global::Generador.Properties.Resources.edit__3_;
            this.btncambiar.ImageActive = global::Generador.Properties.Resources.edit__4_;
            this.btncambiar.Location = new System.Drawing.Point(19, 616);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(82, 71);
            this.btncambiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncambiar.TabIndex = 25;
            this.btncambiar.TabStop = false;
            this.btncambiar.Zoom = 10;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(17, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Status";
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.ItemHeight = 23;
            this.cbstatus.Items.AddRange(new object[] {
            "Aceptado",
            "Rechazado",
            "Pendiente"});
            this.cbstatus.Location = new System.Drawing.Point(122, 471);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(191, 29);
            this.cbstatus.TabIndex = 23;
            this.cbstatus.UseSelectable = true;
            // 
            // btngen
            // 
            this.btngen.BackColor = System.Drawing.Color.Transparent;
            this.btngen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngen.Image = global::Generador.Properties.Resources.contract;
            this.btngen.ImageActive = global::Generador.Properties.Resources.contract__1_;
            this.btngen.Location = new System.Drawing.Point(143, 616);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(82, 71);
            this.btngen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btngen.TabIndex = 5;
            this.btngen.TabStop = false;
            this.btngen.Zoom = 10;
            this.btngen.Click += new System.EventHandler(this.btngen_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Location = new System.Drawing.Point(118, 6);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 20);
            this.lblid.TabIndex = 21;
            this.lblid.Text = " ";
            this.lblid.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(120, 699);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Generar Archivo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(256, 699);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Refrescar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(11, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "ID";
            this.label13.Visible = false;
            // 
            // btnrefresj
            // 
            this.btnrefresj.BackColor = System.Drawing.Color.Transparent;
            this.btnrefresj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresj.Image = global::Generador.Properties.Resources.reload__1_;
            this.btnrefresj.ImageActive = global::Generador.Properties.Resources.reload;
            this.btnrefresj.Location = new System.Drawing.Point(260, 616);
            this.btnrefresj.Name = "btnrefresj";
            this.btnrefresj.Size = new System.Drawing.Size(71, 71);
            this.btnrefresj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrefresj.TabIndex = 8;
            this.btnrefresj.TabStop = false;
            this.btnrefresj.Zoom = 10;
            this.btnrefresj.Click += new System.EventHandler(this.btnrefresj_Click);
            // 
            // lblcorreoD
            // 
            this.lblcorreoD.AutoSize = true;
            this.lblcorreoD.BackColor = System.Drawing.Color.Transparent;
            this.lblcorreoD.Location = new System.Drawing.Point(119, 368);
            this.lblcorreoD.Name = "lblcorreoD";
            this.lblcorreoD.Size = new System.Drawing.Size(13, 20);
            this.lblcorreoD.TabIndex = 19;
            this.lblcorreoD.Text = ".";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Image = global::Generador.Properties.Resources.delete;
            this.btneliminar.ImageActive = global::Generador.Properties.Resources.delete__2_;
            this.btneliminar.Location = new System.Drawing.Point(367, 616);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(71, 71);
            this.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneliminar.TabIndex = 4;
            this.btneliminar.TabStop = false;
            this.btneliminar.Zoom = 10;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblcorreo.Location = new System.Drawing.Point(119, 327);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(13, 20);
            this.lblcorreo.TabIndex = 18;
            this.lblcorreo.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(341, 699);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Quitar Solicitud";
            // 
            // lblempresa
            // 
            this.lblempresa.AutoSize = true;
            this.lblempresa.BackColor = System.Drawing.Color.Transparent;
            this.lblempresa.Location = new System.Drawing.Point(117, 169);
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(13, 20);
            this.lblempresa.TabIndex = 16;
            this.lblempresa.Text = ".";
            // 
            // lblasesor
            // 
            this.lblasesor.AutoSize = true;
            this.lblasesor.BackColor = System.Drawing.Color.Transparent;
            this.lblasesor.Location = new System.Drawing.Point(122, 210);
            this.lblasesor.Name = "lblasesor";
            this.lblasesor.Size = new System.Drawing.Size(13, 20);
            this.lblasesor.TabIndex = 14;
            this.lblasesor.Text = ".";
            // 
            // lblproyecto
            // 
            this.lblproyecto.AutoSize = true;
            this.lblproyecto.BackColor = System.Drawing.Color.Transparent;
            this.lblproyecto.Location = new System.Drawing.Point(119, 249);
            this.lblproyecto.Name = "lblproyecto";
            this.lblproyecto.Size = new System.Drawing.Size(13, 20);
            this.lblproyecto.TabIndex = 13;
            this.lblproyecto.Text = ".";
            // 
            // lblcarrera
            // 
            this.lblcarrera.AutoSize = true;
            this.lblcarrera.BackColor = System.Drawing.Color.Transparent;
            this.lblcarrera.Location = new System.Drawing.Point(119, 288);
            this.lblcarrera.Name = "lblcarrera";
            this.lblcarrera.Size = new System.Drawing.Size(13, 20);
            this.lblcarrera.TabIndex = 12;
            this.lblcarrera.Text = ".";
            // 
            // lblnombreD
            // 
            this.lblnombreD.AutoSize = true;
            this.lblnombreD.BackColor = System.Drawing.Color.Transparent;
            this.lblnombreD.Location = new System.Drawing.Point(116, 130);
            this.lblnombreD.Name = "lblnombreD";
            this.lblnombreD.Size = new System.Drawing.Size(13, 20);
            this.lblnombreD.TabIndex = 11;
            this.lblnombreD.Text = ".";
            // 
            // lblctl
            // 
            this.lblctl.AutoSize = true;
            this.lblctl.BackColor = System.Drawing.Color.Transparent;
            this.lblctl.Location = new System.Drawing.Point(116, 94);
            this.lblctl.Name = "lblctl";
            this.lblctl.Size = new System.Drawing.Size(13, 20);
            this.lblctl.TabIndex = 10;
            this.lblctl.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(12, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Asesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrera";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Location = new System.Drawing.Point(9, 130);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcontrol
            // 
            this.lblcontrol.AutoSize = true;
            this.lblcontrol.BackColor = System.Drawing.Color.Transparent;
            this.lblcontrol.Location = new System.Drawing.Point(9, 94);
            this.lblcontrol.Name = "lblcontrol";
            this.lblcontrol.Size = new System.Drawing.Size(88, 20);
            this.lblcontrol.TabIndex = 0;
            this.lblcontrol.Text = "No. Control";
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.label14);
            this.bunifuGradientPanel3.Controls.Add(this.metroComboBox1);
            this.bunifuGradientPanel3.Controls.Add(this.txtbuscar);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel3.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel3.Controls.Add(this.btnacercaDe);
            this.bunifuGradientPanel3.Controls.Add(this.label1);
            this.bunifuGradientPanel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(13, 42);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1873, 980);
            this.bunifuGradientPanel3.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(489, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ordenar";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Todos",
            "Pendientes",
            "Aceptados",
            "Rechazados"});
            this.metroComboBox1.Location = new System.Drawing.Point(493, 85);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(181, 29);
            this.metroComboBox1.TabIndex = 16;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.DarkGray;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbuscar.HintForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.HintText = "Buscar";
            this.txtbuscar.isPassword = false;
            this.txtbuscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtbuscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbuscar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbuscar.LineThickness = 3;
            this.txtbuscar.Location = new System.Drawing.Point(17, 894);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(476, 67);
            this.txtbuscar.TabIndex = 22;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.OnValueChanged += new System.EventHandler(this.txtbuscar_OnValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::Generador.Properties.Resources.error__4_;
            this.bunifuImageButton1.ImageActive = global::Generador.Properties.Resources.error__5_;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1785, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(64, 58);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 15;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.bunifuImageButton1.MouseHover += new System.EventHandler(this.bunifuImageButton1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Generador.Properties.Resources.logos;
            this.pictureBox1.Location = new System.Drawing.Point(17, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnacercaDe
            // 
            this.btnacercaDe.BackColor = System.Drawing.Color.Transparent;
            this.btnacercaDe.Image = global::Generador.Properties.Resources.logoblack;
            this.btnacercaDe.ImageActive = null;
            this.btnacercaDe.Location = new System.Drawing.Point(1753, 883);
            this.btnacercaDe.Name = "btnacercaDe";
            this.btnacercaDe.Size = new System.Drawing.Size(96, 94);
            this.btnacercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnacercaDe.TabIndex = 14;
            this.btnacercaDe.TabStop = false;
            this.btnacercaDe.Zoom = 10;
            this.btnacercaDe.Click += new System.EventHandler(this.btnacercaDe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(426, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 1053);
            this.ControlBox = false;
            this.Controls.Add(this.dgvinfo);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncambiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrefresj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnacercaDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcontrol;
        private Bunifu.Framework.UI.BunifuImageButton btneliminar;
        private Bunifu.Framework.UI.BunifuImageButton btngen;
        private System.Windows.Forms.Label lblcorreoD;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lblempresa;
        private System.Windows.Forms.Label lblasesor;
        private System.Windows.Forms.Label lblproyecto;
        private System.Windows.Forms.Label lblcarrera;
        private System.Windows.Forms.Label lblnombreD;
        private System.Windows.Forms.Label lblctl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuImageButton btnrefresj;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvinfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnacercaDe;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbuscar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroComboBox cbstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuImageButton btncambiar;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}

