namespace Registro_economico
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
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcIngreso = new System.Windows.Forms.GroupBox();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcGastosExtra = new System.Windows.Forms.GroupBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.mrcIngreso.SuspendLayout();
            this.mrcGastosFijos.SuspendLayout();
            this.mrcGastosExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(18, 33);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(74, 19);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito:";
            // 
            // mrcIngreso
            // 
            this.mrcIngreso.Controls.Add(this.txtDeposito);
            this.mrcIngreso.Controls.Add(this.lblDeposito);
            this.mrcIngreso.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngreso.Location = new System.Drawing.Point(24, 12);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Size = new System.Drawing.Size(223, 69);
            this.mrcIngreso.TabIndex = 1;
            this.mrcIngreso.TabStop = false;
            this.mrcIngreso.Text = "Ingreso";
            // 
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.Controls.Add(this.txtComida);
            this.mrcGastosFijos.Controls.Add(this.txtImpuestos);
            this.mrcGastosFijos.Controls.Add(this.txtAlquiler);
            this.mrcGastosFijos.Controls.Add(this.label5);
            this.mrcGastosFijos.Controls.Add(this.lblComida);
            this.mrcGastosFijos.Controls.Add(this.lblImpuestos);
            this.mrcGastosFijos.Controls.Add(this.lblAlquiler);
            this.mrcGastosFijos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosFijos.Location = new System.Drawing.Point(24, 87);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Size = new System.Drawing.Size(223, 120);
            this.mrcGastosFijos.TabIndex = 2;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "Gastos Fijos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 3;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.Location = new System.Drawing.Point(21, 88);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(64, 19);
            this.lblComida.TabIndex = 2;
            this.lblComida.Text = "Comida:";
            this.lblComida.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(18, 59);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(83, 19);
            this.lblImpuestos.TabIndex = 1;
            this.lblImpuestos.Text = "Impuestos:";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(18, 34);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(67, 19);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler:";
            // 
            // mrcGastosExtra
            // 
            this.mrcGastosExtra.Controls.Add(this.txtMonto);
            this.mrcGastosExtra.Controls.Add(this.lblMonto);
            this.mrcGastosExtra.Controls.Add(this.label6);
            this.mrcGastosExtra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosExtra.Location = new System.Drawing.Point(24, 218);
            this.mrcGastosExtra.Name = "mrcGastosExtra";
            this.mrcGastosExtra.Size = new System.Drawing.Size(223, 76);
            this.mrcGastosExtra.TabIndex = 3;
            this.mrcGastosExtra.TabStop = false;
            this.mrcGastosExtra.Text = "Gastos Extra";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(32, 37);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(60, 19);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 3;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(153, 319);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(94, 23);
            this.cmdCalcular.TabIndex = 4;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(49, 319);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(98, 23);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(98, 33);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(93, 22);
            this.txtDeposito.TabIndex = 1;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlquiler.Location = new System.Drawing.Point(98, 34);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(93, 22);
            this.txtAlquiler.TabIndex = 4;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(98, 62);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(93, 22);
            this.txtImpuestos.TabIndex = 5;
            // 
            // txtComida
            // 
            this.txtComida.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComida.Location = new System.Drawing.Point(98, 89);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(93, 22);
            this.txtComida.TabIndex = 6;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(98, 38);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(93, 22);
            this.txtMonto.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 370);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.mrcGastosExtra);
            this.Controls.Add(this.mrcGastosFijos);
            this.Controls.Add(this.mrcIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro Economico ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcIngreso.ResumeLayout(false);
            this.mrcIngreso.PerformLayout();
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.mrcGastosExtra.ResumeLayout(false);
            this.mrcGastosExtra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.GroupBox mrcIngreso;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.GroupBox mrcGastosExtra;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtMonto;
    }
}

