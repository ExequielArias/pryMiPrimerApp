﻿namespace Registro_economico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacena));
            this.mrcControlDeAlacena = new System.Windows.Forms.GroupBox();
            this.cboLugar = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpVence = new System.Windows.Forms.DateTimePicker();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lstAlacena = new System.Windows.Forms.ListBox();
            this.chkVence = new System.Windows.Forms.CheckBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.mrcControlDeAlacena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcControlDeAlacena
            // 
            this.mrcControlDeAlacena.Controls.Add(this.cmdBorrar);
            this.mrcControlDeAlacena.Controls.Add(this.chkVence);
            this.mrcControlDeAlacena.Controls.Add(this.lstAlacena);
            this.mrcControlDeAlacena.Controls.Add(this.cmdCargar);
            this.mrcControlDeAlacena.Controls.Add(this.dtpVence);
            this.mrcControlDeAlacena.Controls.Add(this.nudCantidad);
            this.mrcControlDeAlacena.Controls.Add(this.cboNombre);
            this.mrcControlDeAlacena.Controls.Add(this.lblCantidad);
            this.mrcControlDeAlacena.Controls.Add(this.lblLugar);
            this.mrcControlDeAlacena.Controls.Add(this.lblNombre);
            this.mrcControlDeAlacena.Controls.Add(this.cboLugar);
            this.mrcControlDeAlacena.Location = new System.Drawing.Point(20, 12);
            this.mrcControlDeAlacena.Name = "mrcControlDeAlacena";
            this.mrcControlDeAlacena.Size = new System.Drawing.Size(349, 377);
            this.mrcControlDeAlacena.TabIndex = 17;
            this.mrcControlDeAlacena.TabStop = false;
            this.mrcControlDeAlacena.Text = "Control de Alacena";
            // 
            // cboLugar
            // 
            this.cboLugar.FormattingEnabled = true;
            this.cboLugar.Items.AddRange(new object[] {
            "Alacena",
            "Heladera",
            "freezer"});
            this.cboLugar.Location = new System.Drawing.Point(26, 48);
            this.cboLugar.Name = "cboLugar";
            this.cboLugar.Size = new System.Drawing.Size(99, 21);
            this.cboLugar.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(128, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(23, 28);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(41, 18);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Lugar";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(233, 28);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(63, 18);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cboNombre
            // 
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Items.AddRange(new object[] {
            "Huevos ",
            "Leche ",
            "Arroz",
            "Fideos",
            "Mermelada",
            "Verduras",
            "Carnes ",
            "Queso",
            "Legumbres",
            "Frutas",
            "Bebidas"});
            this.cboNombre.Location = new System.Drawing.Point(131, 48);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(99, 21);
            this.cboNombre.TabIndex = 4;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(236, 49);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(99, 20);
            this.nudCantidad.TabIndex = 5;
            // 
            // dtpVence
            // 
            this.dtpVence.Location = new System.Drawing.Point(55, 107);
            this.dtpVence.Name = "dtpVence";
            this.dtpVence.Size = new System.Drawing.Size(260, 20);
            this.dtpVence.TabIndex = 7;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(181, 144);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(115, 23);
            this.cmdCargar.TabIndex = 8;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.ItemHeight = 15;
            this.lstAlacena.Location = new System.Drawing.Point(26, 184);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(309, 184);
            this.lstAlacena.TabIndex = 9;
            this.lstAlacena.SelectedIndexChanged += new System.EventHandler(this.lstAlacena_SelectedIndexChanged);
            // 
            // chkVence
            // 
            this.chkVence.AutoSize = true;
            this.chkVence.Location = new System.Drawing.Point(55, 84);
            this.chkVence.Name = "chkVence";
            this.chkVence.Size = new System.Drawing.Size(57, 17);
            this.chkVence.TabIndex = 10;
            this.chkVence.Text = "Vence";
            this.chkVence.UseVisualStyleBackColor = true;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(60, 144);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(115, 23);
            this.cmdBorrar.TabIndex = 11;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 405);
            this.Controls.Add(this.mrcControlDeAlacena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAlacena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.mrcControlDeAlacena.ResumeLayout(false);
            this.mrcControlDeAlacena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox mrcControlDeAlacena;
        private System.Windows.Forms.ListBox lstAlacena;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.DateTimePicker dtpVence;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cboNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboLugar;
        private System.Windows.Forms.CheckBox chkVence;
        private System.Windows.Forms.Button cmdBorrar;
    }
}