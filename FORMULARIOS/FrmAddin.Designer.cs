
namespace FORMULARIOS
{
    partial class FrmAddin
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btactualizar = new System.Windows.Forms.Button();
            this.btagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(421, 239);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(84, 23);
            this.btneliminar.TabIndex = 27;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btactualizar
            // 
            this.btactualizar.Location = new System.Drawing.Point(220, 239);
            this.btactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(99, 23);
            this.btactualizar.TabIndex = 26;
            this.btactualizar.Text = "ACTUALIZAR";
            this.btactualizar.UseVisualStyleBackColor = true;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // btagregar
            // 
            this.btagregar.Location = new System.Drawing.Point(31, 239);
            this.btagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(125, 23);
            this.btagregar.TabIndex = 25;
            this.btagregar.Text = "AGREGAR";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "NEGOCIOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(649, 170);
            this.txtfech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(100, 22);
            this.txtfech.TabIndex = 18;
            this.txtfech.TextChanged += new System.EventHandler(this.txtfech_TextChanged);
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(457, 170);
            this.txtdes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(160, 22);
            this.txtdes.TabIndex = 17;
            this.txtdes.TextChanged += new System.EventHandler(this.txtdes_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "CODIGO ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "RUC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "DESCRIPCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "FECHA";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(31, 170);
            this.txtcod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 22);
            this.txtcod.TabIndex = 33;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(150, 170);
            this.txtnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(133, 22);
            this.txtnom.TabIndex = 34;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(304, 170);
            this.txtruc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(127, 22);
            this.txtruc.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfech);
            this.Controls.Add(this.txtdes);
            this.Name = "FrmAddin";
            this.Text = "FrmAddin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Button button1;
    }
}