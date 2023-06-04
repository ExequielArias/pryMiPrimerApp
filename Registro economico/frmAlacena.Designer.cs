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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacena));
            this.mrcControlDeAlacena = new System.Windows.Forms.GroupBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.chkVence = new System.Windows.Forms.CheckBox();
            this.cboLugar = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpVence = new System.Windows.Forms.DateTimePicker();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lstAlacena = new System.Windows.Forms.ListBox();
            this.mrcControlDeAlacena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcControlDeAlacena
            // 
            this.mrcControlDeAlacena.Controls.Add(this.lstAlacena);
            this.mrcControlDeAlacena.Controls.Add(this.cmdCargar);
            this.mrcControlDeAlacena.Controls.Add(this.cmdBorrar);
            this.mrcControlDeAlacena.Controls.Add(this.dtpVence);
            this.mrcControlDeAlacena.Controls.Add(this.nudCantidad);
            this.mrcControlDeAlacena.Controls.Add(this.cboLugar);
            this.mrcControlDeAlacena.Controls.Add(this.chkVence);
            this.mrcControlDeAlacena.Controls.Add(this.cboProducto);
            this.mrcControlDeAlacena.Controls.Add(this.lblCantidad);
            this.mrcControlDeAlacena.Controls.Add(this.lblProducto);
            this.mrcControlDeAlacena.Controls.Add(this.lblLugar);
            this.mrcControlDeAlacena.Location = new System.Drawing.Point(12, 12);
            this.mrcControlDeAlacena.Name = "mrcControlDeAlacena";
            this.mrcControlDeAlacena.Size = new System.Drawing.Size(414, 465);
            this.mrcControlDeAlacena.TabIndex = 0;
            this.mrcControlDeAlacena.TabStop = false;
            this.mrcControlDeAlacena.Text = "Control De Alacena";
            this.mrcControlDeAlacena.Enter += new System.EventHandler(this.mrcControlDeAlacena_Enter);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(16, 24);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(47, 19);
            this.lblLugar.TabIndex = 0;
            this.lblLugar.Text = "Lugar";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(147, 24);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 19);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(270, 24);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 19);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Leche",
            "Huevos",
            "Arroz",
            "Mermelada",
            "Fideos",
            "Queso",
            "Manteca",
            "Hierva",
            "Cafe",
            "Azucar",
            "Carne",
            "Pollo",
            "Pescado",
            "Helado",
            "Jamon",
            "Pan",
            "Ravioles",
            "Pritty",
            "Coca-Cola",
            "Secco",
            "Agua"});
            this.cboProducto.Location = new System.Drawing.Point(147, 46);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 5;
            // 
            // chkVence
            // 
            this.chkVence.AutoSize = true;
            this.chkVence.Location = new System.Drawing.Point(56, 84);
            this.chkVence.Name = "chkVence";
            this.chkVence.Size = new System.Drawing.Size(57, 17);
            this.chkVence.TabIndex = 7;
            this.chkVence.Text = "Vence";
            this.chkVence.UseVisualStyleBackColor = true;
            // 
            // cboLugar
            // 
            this.cboLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLugar.FormattingEnabled = true;
            this.cboLugar.Items.AddRange(new object[] {
            "Alacena",
            "Heladera",
            "Freezer"});
            this.cboLugar.Location = new System.Drawing.Point(20, 47);
            this.cboLugar.Name = "cboLugar";
            this.cboLugar.Size = new System.Drawing.Size(121, 21);
            this.cboLugar.TabIndex = 8;
            this.cboLugar.SelectedIndexChanged += new System.EventHandler(this.cboLugar_SelectedIndexChanged);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(274, 48);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(121, 20);
            this.nudCantidad.TabIndex = 9;
            // 
            // dtpVence
            // 
            this.dtpVence.Location = new System.Drawing.Point(56, 107);
            this.dtpVence.Name = "dtpVence";
            this.dtpVence.Size = new System.Drawing.Size(283, 20);
            this.dtpVence.TabIndex = 10;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(98, 144);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(104, 23);
            this.cmdBorrar.TabIndex = 11;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(208, 144);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(104, 23);
            this.cmdCargar.TabIndex = 12;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.Location = new System.Drawing.Point(20, 173);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(375, 277);
            this.lstAlacena.TabIndex = 13;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 489);
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
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.CheckBox chkVence;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cboLugar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.DateTimePicker dtpVence;
        private System.Windows.Forms.ListBox lstAlacena;
    }
}