﻿namespace Registro_economico
{
    partial class frmFinanza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanza));
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.mrcGastosExtra = new System.Windows.Forms.GroupBox();
            this.lbl_____ = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcIngreso = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcGastosExtra.SuspendLayout();
            this.mrcGastosFijos.SuspendLayout();
            this.mrcIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(21, 317);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(98, 23);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Borrar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(125, 317);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(94, 23);
            this.cmdCalcular.TabIndex = 9;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // mrcGastosExtra
            // 
            this.mrcGastosExtra.Controls.Add(this.lbl_____);
            this.mrcGastosExtra.Controls.Add(this.lblMonto);
            this.mrcGastosExtra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosExtra.Location = new System.Drawing.Point(12, 218);
            this.mrcGastosExtra.Name = "mrcGastosExtra";
            this.mrcGastosExtra.Size = new System.Drawing.Size(207, 76);
            this.mrcGastosExtra.TabIndex = 8;
            this.mrcGastosExtra.TabStop = false;
            this.mrcGastosExtra.Text = "Sobrante";
            // 
            // lbl_____
            // 
            this.lbl_____.AutoSize = true;
            this.lbl_____.Location = new System.Drawing.Point(98, 29);
            this.lbl_____.Name = "lbl_____";
            this.lbl_____.Size = new System.Drawing.Size(73, 29);
            this.lbl_____.TabIndex = 5;
            this.lbl_____.Text = "_____";
            this.lbl_____.Click += new System.EventHandler(this.label1_Click);
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
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.Controls.Add(this.txtComida);
            this.mrcGastosFijos.Controls.Add(this.txtImpuestos);
            this.mrcGastosFijos.Controls.Add(this.txtAlquiler);
            this.mrcGastosFijos.Controls.Add(this.lblComida);
            this.mrcGastosFijos.Controls.Add(this.lblImpuestos);
            this.mrcGastosFijos.Controls.Add(this.lblAlquiler);
            this.mrcGastosFijos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosFijos.Location = new System.Drawing.Point(12, 87);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Size = new System.Drawing.Size(207, 120);
            this.mrcGastosFijos.TabIndex = 7;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "Gastos Fijos";
            // 
            // txtComida
            // 
            this.txtComida.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComida.Location = new System.Drawing.Point(98, 89);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(93, 22);
            this.txtComida.TabIndex = 6;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(98, 62);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(93, 22);
            this.txtImpuestos.TabIndex = 5;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlquiler.Location = new System.Drawing.Point(98, 34);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(93, 22);
            this.txtAlquiler.TabIndex = 4;
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
            // mrcIngreso
            // 
            this.mrcIngreso.Controls.Add(this.txtDeposito);
            this.mrcIngreso.Controls.Add(this.lblDeposito);
            this.mrcIngreso.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngreso.Location = new System.Drawing.Point(12, 12);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Size = new System.Drawing.Size(207, 69);
            this.mrcIngreso.TabIndex = 6;
            this.mrcIngreso.TabStop = false;
            this.mrcIngreso.Text = "Ingreso";
            this.mrcIngreso.Enter += new System.EventHandler(this.mrcIngreso_Enter);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(98, 33);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(93, 22);
            this.txtDeposito.TabIndex = 1;
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
            // frmFinanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 362);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.mrcGastosExtra);
            this.Controls.Add(this.mrcGastosFijos);
            this.Controls.Add(this.mrcIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFinanza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finanza";
            this.Load += new System.EventHandler(this.frmFinanza_Load);
            this.mrcGastosExtra.ResumeLayout(false);
            this.mrcGastosExtra.PerformLayout();
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.mrcIngreso.ResumeLayout(false);
            this.mrcIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.GroupBox mrcGastosExtra;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.GroupBox mrcIngreso;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lbl_____;
    }
}