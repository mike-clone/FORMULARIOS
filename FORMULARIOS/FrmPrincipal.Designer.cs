﻿
namespace FORMULARIOS
{
    partial class FrmPrincipal
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
            this.btnOmar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOmar
            // 
            this.btnOmar.Location = new System.Drawing.Point(21, 43);
            this.btnOmar.Name = "btnOmar";
            this.btnOmar.Size = new System.Drawing.Size(140, 71);
            this.btnOmar.TabIndex = 0;
            this.btnOmar.Text = "omar";
            this.btnOmar.UseVisualStyleBackColor = true;
            this.btnOmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gianella";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "Addin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 71);
            this.button4.TabIndex = 3;
            this.button4.Text = "cleiner";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(215, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 71);
            this.button5.TabIndex = 4;
            this.button5.Text = "Yeyson";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(423, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 71);
            this.button6.TabIndex = 5;
            this.button6.Text = "miguel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(629, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 71);
            this.button7.TabIndex = 6;
            this.button7.Text = "Mary";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(639, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOmar);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOmar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSalir;
    }
}

