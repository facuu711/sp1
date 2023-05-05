namespace sp1
{
    partial class frmFinanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanzas));
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinanzas = new System.Windows.Forms.Label();
            this.mrcGastosMensuales = new System.Windows.Forms.GroupBox();
            this.txtSalidas = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.txtFinanzas = new System.Windows.Forms.TextBox();
            this.lblGastosVarios = new System.Windows.Forms.Label();
            this.txtGastosVarios = new System.Windows.Forms.TextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblSaldoRestante = new System.Windows.Forms.Label();
            this.lblSaldoRestante2 = new System.Windows.Forms.Label();
            this.mrcGastosMensuales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblFinanzas
            // 
            this.lblFinanzas.AutoSize = true;
            this.lblFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanzas.Location = new System.Drawing.Point(29, 28);
            this.lblFinanzas.Name = "lblFinanzas";
            this.lblFinanzas.Size = new System.Drawing.Size(109, 29);
            this.lblFinanzas.TabIndex = 1;
            this.lblFinanzas.Text = "Finanzas";
            this.lblFinanzas.Click += new System.EventHandler(this.TxtFinanzas_Click);
            // 
            // mrcGastosMensuales
            // 
            this.mrcGastosMensuales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcGastosMensuales.Controls.Add(this.txtSalidas);
            this.mrcGastosMensuales.Controls.Add(this.txtComida);
            this.mrcGastosMensuales.Controls.Add(this.txtImpuestos);
            this.mrcGastosMensuales.Controls.Add(this.txtAlquiler);
            this.mrcGastosMensuales.Controls.Add(this.lblSalidas);
            this.mrcGastosMensuales.Controls.Add(this.lblComida);
            this.mrcGastosMensuales.Controls.Add(this.lblImpuestos);
            this.mrcGastosMensuales.Controls.Add(this.lblAlquiler);
            this.mrcGastosMensuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosMensuales.Location = new System.Drawing.Point(34, 102);
            this.mrcGastosMensuales.Name = "mrcGastosMensuales";
            this.mrcGastosMensuales.Size = new System.Drawing.Size(231, 194);
            this.mrcGastosMensuales.TabIndex = 3;
            this.mrcGastosMensuales.TabStop = false;
            this.mrcGastosMensuales.Text = "Gastos Mensuales";
            // 
            // txtSalidas
            // 
            this.txtSalidas.Location = new System.Drawing.Point(95, 107);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.Size = new System.Drawing.Size(100, 26);
            this.txtSalidas.TabIndex = 7;
            this.txtSalidas.Text = "100";
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(95, 135);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(100, 26);
            this.txtComida.TabIndex = 6;
            this.txtComida.Text = "50";
            this.txtComida.TextChanged += new System.EventHandler(this.txtComida_TextChanged);
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(95, 71);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(100, 26);
            this.txtImpuestos.TabIndex = 5;
            this.txtImpuestos.Text = "100";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(95, 37);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(100, 26);
            this.txtAlquiler.TabIndex = 4;
            this.txtAlquiler.Text = "500";
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Location = new System.Drawing.Point(14, 141);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(61, 20);
            this.lblSalidas.TabIndex = 3;
            this.lblSalidas.Text = "Salidas";
            this.lblSalidas.Click += new System.EventHandler(this.txtSalidas_Click);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(14, 110);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(63, 20);
            this.lblComida.TabIndex = 2;
            this.lblComida.Text = "Comida";
            this.lblComida.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(14, 77);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(84, 20);
            this.lblImpuestos.TabIndex = 1;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(14, 43);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(61, 20);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler";
            this.lblAlquiler.Click += new System.EventHandler(this.lblAlquiler_Click);
            // 
            // txtFinanzas
            // 
            this.txtFinanzas.Location = new System.Drawing.Point(144, 37);
            this.txtFinanzas.Name = "txtFinanzas";
            this.txtFinanzas.Size = new System.Drawing.Size(121, 20);
            this.txtFinanzas.TabIndex = 4;
            this.txtFinanzas.Text = "5000";
            // 
            // lblGastosVarios
            // 
            this.lblGastosVarios.AutoSize = true;
            this.lblGastosVarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosVarios.Location = new System.Drawing.Point(31, 308);
            this.lblGastosVarios.Name = "lblGastosVarios";
            this.lblGastosVarios.Size = new System.Drawing.Size(170, 20);
            this.lblGastosVarios.TabIndex = 5;
            this.lblGastosVarios.Text = "Gastos Varios/Ahorros";
            // 
            // txtGastosVarios
            // 
            this.txtGastosVarios.Location = new System.Drawing.Point(35, 331);
            this.txtGastosVarios.Name = "txtGastosVarios";
            this.txtGastosVarios.Size = new System.Drawing.Size(166, 20);
            this.txtGastosVarios.TabIndex = 6;
            this.txtGastosVarios.Text = "0";
            this.txtGastosVarios.TextChanged += new System.EventHandler(this.txtGastosVarios_TextChanged);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(98, 410);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 31);
            this.cmdBorrar.TabIndex = 7;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = false;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(182, 411);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(101, 30);
            this.cmdGuardar.TabIndex = 8;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSaldoRestante
            // 
            this.lblSaldoRestante.AutoSize = true;
            this.lblSaldoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoRestante.Location = new System.Drawing.Point(32, 368);
            this.lblSaldoRestante.Name = "lblSaldoRestante";
            this.lblSaldoRestante.Size = new System.Drawing.Size(141, 24);
            this.lblSaldoRestante.TabIndex = 9;
            this.lblSaldoRestante.Text = "Saldo Restante:";
            this.lblSaldoRestante.Click += new System.EventHandler(this.lblSaldoRestante_Click);
            // 
            // lblSaldoRestante2
            // 
            this.lblSaldoRestante2.AutoSize = true;
            this.lblSaldoRestante2.Location = new System.Drawing.Point(179, 376);
            this.lblSaldoRestante2.Name = "lblSaldoRestante2";
            this.lblSaldoRestante2.Size = new System.Drawing.Size(73, 13);
            this.lblSaldoRestante2.TabIndex = 10;
            this.lblSaldoRestante2.Text = "$__________";
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 453);
            this.Controls.Add(this.lblSaldoRestante2);
            this.Controls.Add(this.lblSaldoRestante);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.txtGastosVarios);
            this.Controls.Add(this.lblGastosVarios);
            this.Controls.Add(this.txtFinanzas);
            this.Controls.Add(this.mrcGastosMensuales);
            this.Controls.Add(this.lblFinanzas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinanzas";
            this.Text = "Gastos Mensuales";
            this.Load += new System.EventHandler(this.frmFinanzas_Load);
            this.mrcGastosMensuales.ResumeLayout(false);
            this.mrcGastosMensuales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFinanzas;
        private System.Windows.Forms.GroupBox mrcGastosMensuales;
        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.TextBox txtSalidas;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtFinanzas;
        private System.Windows.Forms.Label lblGastosVarios;
        private System.Windows.Forms.TextBox txtGastosVarios;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label lblSaldoRestante;
        private System.Windows.Forms.Label lblSaldoRestante2;
    }
}

