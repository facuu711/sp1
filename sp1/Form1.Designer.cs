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
            this.TxtFinanzas = new System.Windows.Forms.Label();
            this.mrcGastosMensuales = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSalidas = new System.Windows.Forms.Label();
            this.txtComido = new System.Windows.Forms.Label();
            this.txtImpuestos = new System.Windows.Forms.Label();
            this.txtAlquiler = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblGastosVarios = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
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
            // TxtFinanzas
            // 
            this.TxtFinanzas.AutoSize = true;
            this.TxtFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFinanzas.Location = new System.Drawing.Point(29, 28);
            this.TxtFinanzas.Name = "TxtFinanzas";
            this.TxtFinanzas.Size = new System.Drawing.Size(109, 29);
            this.TxtFinanzas.TabIndex = 1;
            this.TxtFinanzas.Text = "Finanzas";
            // 
            // mrcGastosMensuales
            // 
            this.mrcGastosMensuales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcGastosMensuales.Controls.Add(this.textBox4);
            this.mrcGastosMensuales.Controls.Add(this.textBox3);
            this.mrcGastosMensuales.Controls.Add(this.textBox2);
            this.mrcGastosMensuales.Controls.Add(this.textBox1);
            this.mrcGastosMensuales.Controls.Add(this.txtSalidas);
            this.mrcGastosMensuales.Controls.Add(this.txtComido);
            this.mrcGastosMensuales.Controls.Add(this.txtImpuestos);
            this.mrcGastosMensuales.Controls.Add(this.txtAlquiler);
            this.mrcGastosMensuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosMensuales.Location = new System.Drawing.Point(34, 102);
            this.mrcGastosMensuales.Name = "mrcGastosMensuales";
            this.mrcGastosMensuales.Size = new System.Drawing.Size(231, 194);
            this.mrcGastosMensuales.TabIndex = 3;
            this.mrcGastosMensuales.TabStop = false;
            this.mrcGastosMensuales.Text = "Gastos Mensuales";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // txtSalidas
            // 
            this.txtSalidas.AutoSize = true;
            this.txtSalidas.Location = new System.Drawing.Point(14, 141);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.Size = new System.Drawing.Size(61, 20);
            this.txtSalidas.TabIndex = 3;
            this.txtSalidas.Text = "Salidas";
            // 
            // txtComido
            // 
            this.txtComido.AutoSize = true;
            this.txtComido.Location = new System.Drawing.Point(14, 110);
            this.txtComido.Name = "txtComido";
            this.txtComido.Size = new System.Drawing.Size(63, 20);
            this.txtComido.TabIndex = 2;
            this.txtComido.Text = "Comida";
            this.txtComido.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.AutoSize = true;
            this.txtImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(14, 77);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(84, 20);
            this.txtImpuestos.TabIndex = 1;
            this.txtImpuestos.Text = "Impuestos";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.AutoSize = true;
            this.txtAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlquiler.Location = new System.Drawing.Point(14, 43);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(61, 20);
            this.txtAlquiler.TabIndex = 0;
            this.txtAlquiler.Text = "Alquiler";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 4;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(35, 331);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(166, 20);
            this.textBox6.TabIndex = 6;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(36, 378);
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
            this.cmdGuardar.Location = new System.Drawing.Point(144, 379);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(101, 30);
            this.cmdGuardar.TabIndex = 8;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 453);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblGastosVarios);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.mrcGastosMensuales);
            this.Controls.Add(this.TxtFinanzas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinanzas";
            this.Text = "Form1";
            this.mrcGastosMensuales.ResumeLayout(false);
            this.mrcGastosMensuales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtFinanzas;
        private System.Windows.Forms.GroupBox mrcGastosMensuales;
        private System.Windows.Forms.Label txtSalidas;
        private System.Windows.Forms.Label txtComido;
        private System.Windows.Forms.Label txtImpuestos;
        private System.Windows.Forms.Label txtAlquiler;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblGastosVarios;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdGuardar;
    }
}

