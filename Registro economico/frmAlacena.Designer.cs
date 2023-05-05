namespace Registro_economico
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
            this.optComida = new System.Windows.Forms.RadioButton();
            this.optMedicamentos = new System.Windows.Forms.RadioButton();
            this.optLimpieza = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblcantidadMinima = new System.Windows.Forms.Label();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.chkCaduca = new System.Windows.Forms.CheckBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.dtpVencimineto = new System.Windows.Forms.DateTimePicker();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadMinima = new System.Windows.Forms.NumericUpDown();
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.mrcControlDeAlacena = new System.Windows.Forms.GroupBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMinima)).BeginInit();
            this.mrcTipo.SuspendLayout();
            this.mrcControlDeAlacena.SuspendLayout();
            this.SuspendLayout();
            // 
            // optComida
            // 
            this.optComida.AutoSize = true;
            this.optComida.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optComida.Location = new System.Drawing.Point(19, 31);
            this.optComida.Name = "optComida";
            this.optComida.Size = new System.Drawing.Size(67, 19);
            this.optComida.TabIndex = 0;
            this.optComida.TabStop = true;
            this.optComida.Text = "Comida";
            this.optComida.UseVisualStyleBackColor = true;
            // 
            // optMedicamentos
            // 
            this.optMedicamentos.AutoSize = true;
            this.optMedicamentos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMedicamentos.Location = new System.Drawing.Point(103, 31);
            this.optMedicamentos.Name = "optMedicamentos";
            this.optMedicamentos.Size = new System.Drawing.Size(106, 19);
            this.optMedicamentos.TabIndex = 1;
            this.optMedicamentos.TabStop = true;
            this.optMedicamentos.Text = "Medicamentos";
            this.optMedicamentos.UseVisualStyleBackColor = true;
            // 
            // optLimpieza
            // 
            this.optLimpieza.AutoSize = true;
            this.optLimpieza.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optLimpieza.Location = new System.Drawing.Point(227, 31);
            this.optLimpieza.Name = "optLimpieza";
            this.optLimpieza.Size = new System.Drawing.Size(73, 19);
            this.optLimpieza.TabIndex = 2;
            this.optLimpieza.TabStop = true;
            this.optLimpieza.Text = "Limpieza";
            this.optLimpieza.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(63, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(63, 145);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblcantidadMinima
            // 
            this.lblcantidadMinima.AutoSize = true;
            this.lblcantidadMinima.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadMinima.Location = new System.Drawing.Point(63, 185);
            this.lblcantidadMinima.Name = "lblcantidadMinima";
            this.lblcantidadMinima.Size = new System.Drawing.Size(129, 19);
            this.lblcantidadMinima.TabIndex = 7;
            this.lblcantidadMinima.Text = "Cantidad Minima:";
            // 
            // cboNombre
            // 
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(138, 105);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(121, 21);
            this.cboNombre.TabIndex = 8;
            // 
            // chkCaduca
            // 
            this.chkCaduca.AutoSize = true;
            this.chkCaduca.Location = new System.Drawing.Point(98, 231);
            this.chkCaduca.Name = "chkCaduca";
            this.chkCaduca.Size = new System.Drawing.Size(63, 17);
            this.chkCaduca.TabIndex = 11;
            this.chkCaduca.Text = "Caduca";
            this.chkCaduca.UseVisualStyleBackColor = true;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(63, 270);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(98, 19);
            this.lblVencimiento.TabIndex = 12;
            this.lblVencimiento.Text = "Vencimiento:";
            // 
            // dtpVencimineto
            // 
            this.dtpVencimineto.Location = new System.Drawing.Point(167, 270);
            this.dtpVencimineto.Name = "dtpVencimineto";
            this.dtpVencimineto.Size = new System.Drawing.Size(108, 20);
            this.dtpVencimineto.TabIndex = 13;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(138, 147);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(121, 20);
            this.nudCantidad.TabIndex = 14;
            // 
            // nudCantidadMinima
            // 
            this.nudCantidadMinima.Location = new System.Drawing.Point(189, 187);
            this.nudCantidadMinima.Name = "nudCantidadMinima";
            this.nudCantidadMinima.Size = new System.Drawing.Size(68, 20);
            this.nudCantidadMinima.TabIndex = 15;
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.optLimpieza);
            this.mrcTipo.Controls.Add(this.optMedicamentos);
            this.mrcTipo.Controls.Add(this.optComida);
            this.mrcTipo.Location = new System.Drawing.Point(48, 19);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Size = new System.Drawing.Size(305, 68);
            this.mrcTipo.TabIndex = 16;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo";
            // 
            // mrcControlDeAlacena
            // 
            this.mrcControlDeAlacena.Controls.Add(this.cmdGuardar);
            this.mrcControlDeAlacena.Controls.Add(this.mrcTipo);
            this.mrcControlDeAlacena.Controls.Add(this.nudCantidadMinima);
            this.mrcControlDeAlacena.Controls.Add(this.nudCantidad);
            this.mrcControlDeAlacena.Controls.Add(this.dtpVencimineto);
            this.mrcControlDeAlacena.Controls.Add(this.lblVencimiento);
            this.mrcControlDeAlacena.Controls.Add(this.chkCaduca);
            this.mrcControlDeAlacena.Controls.Add(this.cboNombre);
            this.mrcControlDeAlacena.Controls.Add(this.lblcantidadMinima);
            this.mrcControlDeAlacena.Controls.Add(this.lblCantidad);
            this.mrcControlDeAlacena.Controls.Add(this.lblNombre);
            this.mrcControlDeAlacena.Location = new System.Drawing.Point(20, 20);
            this.mrcControlDeAlacena.Name = "mrcControlDeAlacena";
            this.mrcControlDeAlacena.Size = new System.Drawing.Size(390, 369);
            this.mrcControlDeAlacena.TabIndex = 17;
            this.mrcControlDeAlacena.TabStop = false;
            this.mrcControlDeAlacena.Text = "Control de Alacena";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(129, 322);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(114, 23);
            this.cmdGuardar.TabIndex = 18;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 405);
            this.Controls.Add(this.mrcControlDeAlacena);
            this.MaximizeBox = false;
            this.Name = "frmAlacena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alacena";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMinima)).EndInit();
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            this.mrcControlDeAlacena.ResumeLayout(false);
            this.mrcControlDeAlacena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton optComida;
        private System.Windows.Forms.RadioButton optMedicamentos;
        private System.Windows.Forms.RadioButton optLimpieza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblcantidadMinima;
        private System.Windows.Forms.ComboBox cboNombre;
        private System.Windows.Forms.CheckBox chkCaduca;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.DateTimePicker dtpVencimineto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidadMinima;
        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.GroupBox mrcControlDeAlacena;
        private System.Windows.Forms.Button cmdGuardar;
    }
}