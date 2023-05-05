namespace sp1
{
    partial class frmAlacena
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
            this.Alacena = new System.Windows.Forms.Label();
            this.mrcAlimentos = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblLimpieza = new System.Windows.Forms.CheckBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mrcFechaDeVencimiento = new System.Windows.Forms.GroupBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cboLugar = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.ListBox();
            this.mrcAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.mrcFechaDeVencimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // Alacena
            // 
            this.Alacena.AutoSize = true;
            this.Alacena.Location = new System.Drawing.Point(161, 9);
            this.Alacena.Name = "Alacena";
            this.Alacena.Size = new System.Drawing.Size(0, 13);
            this.Alacena.TabIndex = 0;
            // 
            // mrcAlimentos
            // 
            this.mrcAlimentos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcAlimentos.Controls.Add(this.cboLugar);
            this.mrcAlimentos.Controls.Add(this.cboProducto);
            this.mrcAlimentos.Controls.Add(this.checkBox3);
            this.mrcAlimentos.Controls.Add(this.checkBox2);
            this.mrcAlimentos.Controls.Add(this.lblLimpieza);
            this.mrcAlimentos.Controls.Add(this.nudCantidad);
            this.mrcAlimentos.Controls.Add(this.txtCantidad);
            this.mrcAlimentos.Controls.Add(this.txtProducto);
            this.mrcAlimentos.Controls.Add(this.txtLugar);
            this.mrcAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAlimentos.Location = new System.Drawing.Point(12, 12);
            this.mrcAlimentos.Name = "mrcAlimentos";
            this.mrcAlimentos.Size = new System.Drawing.Size(398, 184);
            this.mrcAlimentos.TabIndex = 1;
            this.mrcAlimentos.TabStop = false;
            this.mrcAlimentos.Text = "Alimentos";
            this.mrcAlimentos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(251, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(147, 29);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Condimentos";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(134, 93);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 29);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Comida";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblLimpieza
            // 
            this.lblLimpieza.AutoSize = true;
            this.lblLimpieza.Location = new System.Drawing.Point(0, 93);
            this.lblLimpieza.Name = "lblLimpieza";
            this.lblLimpieza.Size = new System.Drawing.Size(109, 29);
            this.lblLimpieza.TabIndex = 6;
            this.lblLimpieza.Text = "Limpieza";
            this.lblLimpieza.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(267, 57);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(74, 30);
            this.nudCantidad.TabIndex = 5;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Location = new System.Drawing.Point(262, 26);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(91, 25);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "Cantidad";
            // 
            // txtProducto
            // 
            this.txtProducto.AutoSize = true;
            this.txtProducto.Location = new System.Drawing.Point(129, 26);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(90, 25);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.Text = "Producto";
            this.txtProducto.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.AutoSize = true;
            this.txtLugar.Location = new System.Drawing.Point(6, 26);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(62, 25);
            this.txtLugar.TabIndex = 0;
            this.txtLugar.Text = "Lugar";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // mrcFechaDeVencimiento
            // 
            this.mrcFechaDeVencimiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcFechaDeVencimiento.Controls.Add(this.dateTimePicker1);
            this.mrcFechaDeVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcFechaDeVencimiento.Location = new System.Drawing.Point(12, 202);
            this.mrcFechaDeVencimiento.Name = "mrcFechaDeVencimiento";
            this.mrcFechaDeVencimiento.Size = new System.Drawing.Size(384, 78);
            this.mrcFechaDeVencimiento.TabIndex = 9;
            this.mrcFechaDeVencimiento.TabStop = false;
            this.mrcFechaDeVencimiento.Text = "Fecha De Vencimiento";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(118, 382);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(131, 33);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(264, 382);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(132, 33);
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Milanesas",
            "Arroz ",
            "Azucar",
            "Agua"});
            this.cboProducto.Location = new System.Drawing.Point(134, 54);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(103, 33);
            this.cboProducto.TabIndex = 10;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cboLugar
            // 
            this.cboLugar.FormattingEnabled = true;
            this.cboLugar.Items.AddRange(new object[] {
            "Heladera",
            "Alacena"});
            this.cboLugar.Location = new System.Drawing.Point(6, 54);
            this.cboLugar.Name = "cboLugar";
            this.cboLugar.Size = new System.Drawing.Size(76, 33);
            this.cboLugar.TabIndex = 11;
            this.cboLugar.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblLista
            // 
            this.lblLista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLista.FormattingEnabled = true;
            this.lblLista.Location = new System.Drawing.Point(12, 287);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(378, 69);
            this.lblLista.TabIndex = 12;
            this.lblLista.SelectedIndexChanged += new System.EventHandler(this.lblLista_SelectedIndexChanged);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 424);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcFechaDeVencimiento);
            this.Controls.Add(this.mrcAlimentos);
            this.Controls.Add(this.Alacena);
            this.Name = "frmAlacena";
            this.Text = "frmAlacena";
            this.mrcAlimentos.ResumeLayout(false);
            this.mrcAlimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.mrcFechaDeVencimiento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alacena;
        private System.Windows.Forms.GroupBox mrcAlimentos;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.Label txtLugar;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox lblLimpieza;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox mrcFechaDeVencimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.ComboBox cboLugar;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ListBox lblLista;
    }
}