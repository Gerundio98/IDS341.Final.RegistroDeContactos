namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnCompañia = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnCargarImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblPosición = new System.Windows.Forms.Label();
            this.txtbPosición = new System.Windows.Forms.TextBox();
            this.cbCompañia = new System.Windows.Forms.ComboBox();
            this.gbGestiónCompañia = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.bttnEliminar2 = new System.Windows.Forms.Button();
            this.bttnBuscar2 = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtbDirección = new System.Windows.Forms.TextBox();
            this.bttnCancelar2 = new System.Windows.Forms.Button();
            this.bttnGuardar2 = new System.Windows.Forms.Button();
            this.lblDireción = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbTelefono2 = new System.Windows.Forms.TextBox();
            this.txtbNombre2 = new System.Windows.Forms.TextBox();
            this.dgvContactosEmpresariales = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.gbGestiónCompañia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosEmpresariales)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbNombre.Location = new System.Drawing.Point(127, 61);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(313, 27);
            this.txtbNombre.TabIndex = 2;
            this.txtbNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbTelefono.Location = new System.Drawing.Point(127, 106);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(156, 27);
            this.txtbTelefono.TabIndex = 3;
            this.txtbTelefono.TextChanged += new System.EventHandler(this.tboxTelefono_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teléfono:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compañia:";
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.bttnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnGuardar.Location = new System.Drawing.Point(30, 254);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(253, 30);
            this.bttnGuardar.TabIndex = 9;
            this.bttnGuardar.Text = "Guardar/Editar";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.PeachPuff;
            this.bttnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnCancelar.Location = new System.Drawing.Point(156, 289);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(127, 31);
            this.bttnCancelar.TabIndex = 10;
            this.bttnCancelar.Text = " Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.gbGestiónCompañia);
            this.groupBox1.Controls.Add(this.bttnCompañia);
            this.groupBox1.Controls.Add(this.bttnEliminar);
            this.groupBox1.Controls.Add(this.bttnBuscar);
            this.groupBox1.Controls.Add(this.bttnCargarImagen);
            this.groupBox1.Controls.Add(this.pbImagen);
            this.groupBox1.Controls.Add(this.lblPosición);
            this.groupBox1.Controls.Add(this.txtbPosición);
            this.groupBox1.Controls.Add(this.bttnCancelar);
            this.groupBox1.Controls.Add(this.bttnGuardar);
            this.groupBox1.Controls.Add(this.cbCompañia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbTelefono);
            this.groupBox1.Controls.Add(this.txtbNombre);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(161, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 346);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bttnCompañia
            // 
            this.bttnCompañia.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bttnCompañia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnCompañia.Location = new System.Drawing.Point(283, 153);
            this.bttnCompañia.Name = "bttnCompañia";
            this.bttnCompañia.Size = new System.Drawing.Size(32, 29);
            this.bttnCompañia.TabIndex = 22;
            this.bttnCompañia.Text = "...";
            this.bttnCompañia.UseVisualStyleBackColor = false;
            this.bttnCompañia.Click += new System.EventHandler(this.bttnCompañia_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.bttnEliminar.Enabled = false;
            this.bttnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnEliminar.Location = new System.Drawing.Point(30, 289);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(120, 31);
            this.bttnEliminar.TabIndex = 21;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.LightCyan;
            this.bttnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnBuscar.Location = new System.Drawing.Point(446, 61);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(62, 29);
            this.bttnBuscar.TabIndex = 20;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnCargarImagen
            // 
            this.bttnCargarImagen.BackColor = System.Drawing.Color.LemonChiffon;
            this.bttnCargarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnCargarImagen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnCargarImagen.Location = new System.Drawing.Point(321, 289);
            this.bttnCargarImagen.Name = "bttnCargarImagen";
            this.bttnCargarImagen.Size = new System.Drawing.Size(187, 29);
            this.bttnCargarImagen.TabIndex = 16;
            this.bttnCargarImagen.Text = "Cargar imagen";
            this.bttnCargarImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnCargarImagen.UseVisualStyleBackColor = false;
            this.bttnCargarImagen.Click += new System.EventHandler(this.bttnCargarImagen_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(321, 96);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(187, 188);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 15;
            this.pbImagen.TabStop = false;
            // 
            // lblPosición
            // 
            this.lblPosición.AutoSize = true;
            this.lblPosición.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPosición.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPosición.Location = new System.Drawing.Point(30, 208);
            this.lblPosición.Name = "lblPosición";
            this.lblPosición.Size = new System.Drawing.Size(85, 23);
            this.lblPosición.TabIndex = 14;
            this.lblPosición.Text = "Posición:";
            // 
            // txtbPosición
            // 
            this.txtbPosición.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbPosición.Location = new System.Drawing.Point(127, 204);
            this.txtbPosición.Name = "txtbPosición";
            this.txtbPosición.Size = new System.Drawing.Size(156, 27);
            this.txtbPosición.TabIndex = 13;
            // 
            // cbCompañia
            // 
            this.cbCompañia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCompañia.FormattingEnabled = true;
            this.cbCompañia.Items.AddRange(new object[] {
            "Claro",
            "Altice ",
            "Viva ",
            "Orange ",
            "T-mobile "});
            this.cbCompañia.Location = new System.Drawing.Point(121, 153);
            this.cbCompañia.Name = "cbCompañia";
            this.cbCompañia.Size = new System.Drawing.Size(156, 28);
            this.cbCompañia.TabIndex = 8;
            this.cbCompañia.SelectedIndexChanged += new System.EventHandler(this.cboxCompañia_SelectedIndexChanged);
            // 
            // gbGestiónCompañia
            // 
            this.gbGestiónCompañia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbGestiónCompañia.Controls.Add(this.cbTipo);
            this.gbGestiónCompañia.Controls.Add(this.bttnEliminar2);
            this.gbGestiónCompañia.Controls.Add(this.bttnBuscar2);
            this.gbGestiónCompañia.Controls.Add(this.lblTipo);
            this.gbGestiónCompañia.Controls.Add(this.txtbDirección);
            this.gbGestiónCompañia.Controls.Add(this.bttnCancelar2);
            this.gbGestiónCompañia.Controls.Add(this.bttnGuardar2);
            this.gbGestiónCompañia.Controls.Add(this.lblDireción);
            this.gbGestiónCompañia.Controls.Add(this.label6);
            this.gbGestiónCompañia.Controls.Add(this.label7);
            this.gbGestiónCompañia.Controls.Add(this.txtbTelefono2);
            this.gbGestiónCompañia.Controls.Add(this.txtbNombre2);
            this.gbGestiónCompañia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbGestiónCompañia.Location = new System.Drawing.Point(0, 0);
            this.gbGestiónCompañia.Name = "gbGestiónCompañia";
            this.gbGestiónCompañia.Size = new System.Drawing.Size(524, 346);
            this.gbGestiónCompañia.TabIndex = 23;
            this.gbGestiónCompañia.TabStop = false;
            this.gbGestiónCompañia.Text = "Gestión compañia";
            this.gbGestiónCompañia.Visible = false;
            this.gbGestiónCompañia.Enter += new System.EventHandler(this.gbGestiónCompañia_Enter);
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "CxA",
            "ONG",
            "SA",
            "Privada",
            "Pública"});
            this.cbTipo.Location = new System.Drawing.Point(127, 199);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(156, 28);
            this.cbTipo.TabIndex = 24;
            // 
            // bttnEliminar2
            // 
            this.bttnEliminar2.BackColor = System.Drawing.Color.IndianRed;
            this.bttnEliminar2.Enabled = false;
            this.bttnEliminar2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnEliminar2.Location = new System.Drawing.Point(30, 289);
            this.bttnEliminar2.Name = "bttnEliminar2";
            this.bttnEliminar2.Size = new System.Drawing.Size(120, 31);
            this.bttnEliminar2.TabIndex = 21;
            this.bttnEliminar2.Text = "Eliminar";
            this.bttnEliminar2.UseVisualStyleBackColor = false;
            this.bttnEliminar2.Click += new System.EventHandler(this.bttnEliminar2_Click);
            // 
            // bttnBuscar2
            // 
            this.bttnBuscar2.BackColor = System.Drawing.Color.LightCyan;
            this.bttnBuscar2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnBuscar2.Location = new System.Drawing.Point(299, 60);
            this.bttnBuscar2.Name = "bttnBuscar2";
            this.bttnBuscar2.Size = new System.Drawing.Size(62, 29);
            this.bttnBuscar2.TabIndex = 20;
            this.bttnBuscar2.Text = "Buscar";
            this.bttnBuscar2.UseVisualStyleBackColor = false;
            this.bttnBuscar2.Click += new System.EventHandler(this.bttnBuscar2_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTipo.Location = new System.Drawing.Point(55, 204);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(53, 23);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtbDirección
            // 
            this.txtbDirección.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbDirección.Location = new System.Drawing.Point(127, 157);
            this.txtbDirección.Name = "txtbDirección";
            this.txtbDirección.Size = new System.Drawing.Size(156, 27);
            this.txtbDirección.TabIndex = 13;
            this.txtbDirección.TextChanged += new System.EventHandler(this.txtbDirección_TextChanged);
            // 
            // bttnCancelar2
            // 
            this.bttnCancelar2.BackColor = System.Drawing.Color.PeachPuff;
            this.bttnCancelar2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnCancelar2.Location = new System.Drawing.Point(156, 289);
            this.bttnCancelar2.Name = "bttnCancelar2";
            this.bttnCancelar2.Size = new System.Drawing.Size(127, 31);
            this.bttnCancelar2.TabIndex = 10;
            this.bttnCancelar2.Text = " Cancelar";
            this.bttnCancelar2.UseVisualStyleBackColor = false;
            this.bttnCancelar2.Click += new System.EventHandler(this.button5_Click);
            // 
            // bttnGuardar2
            // 
            this.bttnGuardar2.BackColor = System.Drawing.Color.LightGreen;
            this.bttnGuardar2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnGuardar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnGuardar2.Location = new System.Drawing.Point(30, 254);
            this.bttnGuardar2.Name = "bttnGuardar2";
            this.bttnGuardar2.Size = new System.Drawing.Size(253, 30);
            this.bttnGuardar2.TabIndex = 9;
            this.bttnGuardar2.Text = "Guardar/Editar";
            this.bttnGuardar2.UseVisualStyleBackColor = false;
            this.bttnGuardar2.Click += new System.EventHandler(this.bttnGuardar2_Click);
            // 
            // lblDireción
            // 
            this.lblDireción.AutoSize = true;
            this.lblDireción.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireción.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDireción.Location = new System.Drawing.Point(15, 158);
            this.lblDireción.Name = "lblDireción";
            this.lblDireción.Size = new System.Drawing.Size(93, 23);
            this.lblDireción.TabIndex = 7;
            this.lblDireción.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(24, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(30, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre:";
            // 
            // txtbTelefono2
            // 
            this.txtbTelefono2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbTelefono2.Location = new System.Drawing.Point(127, 106);
            this.txtbTelefono2.Name = "txtbTelefono2";
            this.txtbTelefono2.Size = new System.Drawing.Size(156, 27);
            this.txtbTelefono2.TabIndex = 3;
            // 
            // txtbNombre2
            // 
            this.txtbNombre2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbNombre2.Location = new System.Drawing.Point(127, 61);
            this.txtbNombre2.Name = "txtbNombre2";
            this.txtbNombre2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbNombre2.Size = new System.Drawing.Size(156, 27);
            this.txtbNombre2.TabIndex = 2;
            // 
            // dgvContactosEmpresariales
            // 
            this.dgvContactosEmpresariales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactosEmpresariales.Location = new System.Drawing.Point(691, 12);
            this.dgvContactosEmpresariales.Name = "dgvContactosEmpresariales";
            this.dgvContactosEmpresariales.RowHeadersWidth = 51;
            this.dgvContactosEmpresariales.RowTemplate.Height = 29;
            this.dgvContactosEmpresariales.Size = new System.Drawing.Size(520, 346);
            this.dgvContactosEmpresariales.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CancelButton = this.bttnCancelar;
            this.ClientSize = new System.Drawing.Size(1240, 376);
            this.Controls.Add(this.dgvContactosEmpresariales);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Agenda de Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.gbGestiónCompañia.ResumeLayout(false);
            this.gbGestiónCompañia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosEmpresariales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox txtbNombre;
        private TextBox txtbTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bttnGuardar;
        private Button bttnCancelar;
        private GroupBox groupBox1;
        private Label lblPosición;
        private TextBox txtbPosición;
        private Button bttnCargarImagen;
        private PictureBox pbImagen;
        private DataGridView dgvContactosEmpresariales;
        private Button bttnBuscar;
        private Button bttnEliminar;
        private OpenFileDialog openFileDialog1;
        private GroupBox gbGestiónCompañia;
        private Button bttnEliminar2;
        private Button bttnBuscar2;
        private Label lblTipo;
        private TextBox txtbDirección;
        private Button bttnCancelar2;
        private Button bttnGuardar2;
        private Label lblDireción;
        private Label label6;
        private Label label7;
        private TextBox txtbTelefono2;
        private TextBox txtbNombre2;
        private Button bttnCompañia;
        private ComboBox cbTipo;
        private ComboBox cbCompañia;
    }
}