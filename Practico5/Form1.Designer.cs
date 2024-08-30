namespace Practico5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNFoto = new System.Windows.Forms.Button();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.CBMujer = new System.Windows.Forms.CheckBox();
            this.CBHombre = new System.Windows.Forms.CheckBox();
            this.TBFoto = new System.Windows.Forms.TextBox();
            this.TBSaldo = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LSexo = new System.Windows.Forms.Label();
            this.LMujer = new System.Windows.Forms.Label();
            this.Lhombre = new System.Windows.Forms.Label();
            this.LSaldo = new System.Windows.Forms.Label();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BTNAgregar);
            this.panel1.Controls.Add(this.BTNFoto);
            this.panel1.Controls.Add(this.DTPFecha);
            this.panel1.Controls.Add(this.CBMujer);
            this.panel1.Controls.Add(this.CBHombre);
            this.panel1.Controls.Add(this.TBFoto);
            this.panel1.Controls.Add(this.TBSaldo);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.LSexo);
            this.panel1.Controls.Add(this.LMujer);
            this.panel1.Controls.Add(this.Lhombre);
            this.panel1.Controls.Add(this.LSaldo);
            this.panel1.Controls.Add(this.LFechaNacimiento);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 351);
            this.panel1.TabIndex = 0;
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BTNAgregar.Image")));
            this.BTNAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAgregar.Location = new System.Drawing.Point(321, 298);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(119, 50);
            this.BTNAgregar.TabIndex = 15;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // BTNFoto
            // 
            this.BTNFoto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFoto.ForeColor = System.Drawing.Color.Black;
            this.BTNFoto.Location = new System.Drawing.Point(28, 251);
            this.BTNFoto.Name = "BTNFoto";
            this.BTNFoto.Size = new System.Drawing.Size(97, 41);
            this.BTNFoto.TabIndex = 14;
            this.BTNFoto.Text = "Foto";
            this.BTNFoto.UseVisualStyleBackColor = true;
            this.BTNFoto.Click += new System.EventHandler(this.BTNFoto_Click);
            // 
            // DTPFecha
            // 
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha.Location = new System.Drawing.Point(307, 105);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(160, 41);
            this.DTPFecha.TabIndex = 13;
            // 
            // CBMujer
            // 
            this.CBMujer.AutoSize = true;
            this.CBMujer.Location = new System.Drawing.Point(239, 165);
            this.CBMujer.Name = "CBMujer";
            this.CBMujer.Size = new System.Drawing.Size(15, 14);
            this.CBMujer.TabIndex = 12;
            this.CBMujer.UseVisualStyleBackColor = true;
            // 
            // CBHombre
            // 
            this.CBHombre.AutoSize = true;
            this.CBHombre.Location = new System.Drawing.Point(123, 165);
            this.CBHombre.Name = "CBHombre";
            this.CBHombre.Size = new System.Drawing.Size(15, 14);
            this.CBHombre.TabIndex = 11;
            this.CBHombre.UseVisualStyleBackColor = true;
            // 
            // TBFoto
            // 
            this.TBFoto.Location = new System.Drawing.Point(150, 251);
            this.TBFoto.Name = "TBFoto";
            this.TBFoto.Size = new System.Drawing.Size(317, 41);
            this.TBFoto.TabIndex = 10;
            // 
            // TBSaldo
            // 
            this.TBSaldo.Location = new System.Drawing.Point(150, 204);
            this.TBSaldo.Name = "TBSaldo";
            this.TBSaldo.Size = new System.Drawing.Size(317, 41);
            this.TBSaldo.TabIndex = 9;
            this.TBSaldo.TextChanged += new System.EventHandler(this.TBSaldo_TextChanged);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(150, 63);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(317, 41);
            this.TBApellido.TabIndex = 8;
            this.TBApellido.TextChanged += new System.EventHandler(this.TBApellido_TextChanged);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(150, 19);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(317, 41);
            this.TBNombre.TabIndex = 7;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSexo.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexo.ForeColor = System.Drawing.Color.White;
            this.LSexo.Location = new System.Drawing.Point(33, 155);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(70, 33);
            this.LSexo.TabIndex = 6;
            this.LSexo.Text = "Sexo:";
            // 
            // LMujer
            // 
            this.LMujer.AutoSize = true;
            this.LMujer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LMujer.Location = new System.Drawing.Point(261, 155);
            this.LMujer.Name = "LMujer";
            this.LMujer.Size = new System.Drawing.Size(70, 33);
            this.LMujer.TabIndex = 5;
            this.LMujer.Text = "Mujer";
            // 
            // Lhombre
            // 
            this.Lhombre.AutoSize = true;
            this.Lhombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lhombre.Location = new System.Drawing.Point(144, 155);
            this.Lhombre.Name = "Lhombre";
            this.Lhombre.Size = new System.Drawing.Size(89, 33);
            this.Lhombre.TabIndex = 4;
            this.Lhombre.Text = "Hombre";
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSaldo.Location = new System.Drawing.Point(33, 207);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(78, 33);
            this.LSaldo.TabIndex = 3;
            this.LSaldo.Text = "Saldo:";
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.BackColor = System.Drawing.Color.Black;
            this.LFechaNacimiento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LFechaNacimiento.Location = new System.Drawing.Point(33, 111);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(180, 33);
            this.LFechaNacimiento.TabIndex = 2;
            this.LFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LApellido.Location = new System.Drawing.Point(33, 71);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(98, 33);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(33, 22);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(92, 33);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            this.LNombre.Click += new System.EventHandler(this.LNombre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 348);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.FechaNacimiento,
            this.Sexo,
            this.Eliminar,
            this.Saldo,
            this.Foto,
            this.Ruta});
            this.dataGridView1.Location = new System.Drawing.Point(21, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario con DataGrid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LMujer;
        private System.Windows.Forms.Label Lhombre;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.CheckBox CBHombre;
        private System.Windows.Forms.TextBox TBFoto;
        private System.Windows.Forms.TextBox TBSaldo;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.CheckBox CBMujer;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNFoto;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewLinkColumn Ruta;
    }
}

