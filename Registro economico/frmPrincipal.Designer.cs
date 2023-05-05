namespace Registro_economico
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmdAlacena = new System.Windows.Forms.Button();
            this.cmdFinanza = new System.Windows.Forms.Button();
            this.lblMostrarInformacionDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAlacena
            // 
            this.cmdAlacena.Location = new System.Drawing.Point(68, 45);
            this.cmdAlacena.Name = "cmdAlacena";
            this.cmdAlacena.Size = new System.Drawing.Size(147, 84);
            this.cmdAlacena.TabIndex = 0;
            this.cmdAlacena.Text = "Alacena";
            this.cmdAlacena.UseVisualStyleBackColor = true;
            this.cmdAlacena.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdFinanza
            // 
            this.cmdFinanza.Location = new System.Drawing.Point(68, 144);
            this.cmdFinanza.Name = "cmdFinanza";
            this.cmdFinanza.Size = new System.Drawing.Size(147, 84);
            this.cmdFinanza.TabIndex = 1;
            this.cmdFinanza.Text = "Finanza";
            this.cmdFinanza.UseVisualStyleBackColor = true;
            this.cmdFinanza.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMostrarInformacionDe
            // 
            this.lblMostrarInformacionDe.AutoSize = true;
            this.lblMostrarInformacionDe.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarInformacionDe.Location = new System.Drawing.Point(12, 9);
            this.lblMostrarInformacionDe.Name = "lblMostrarInformacionDe";
            this.lblMostrarInformacionDe.Size = new System.Drawing.Size(264, 29);
            this.lblMostrarInformacionDe.TabIndex = 2;
            this.lblMostrarInformacionDe.Text = "Mostrar indormacion de:";
            this.lblMostrarInformacionDe.Click += new System.EventHandler(this.lblMostrarInformacionDe_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 247);
            this.Controls.Add(this.lblMostrarInformacionDe);
            this.Controls.Add(this.cmdFinanza);
            this.Controls.Add(this.cmdAlacena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAlacena;
        private System.Windows.Forms.Button cmdFinanza;
        private System.Windows.Forms.Label lblMostrarInformacionDe;
    }
}