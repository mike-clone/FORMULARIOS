
namespace FORMULARIOS
{
    partial class FrmMiguel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.btagregar = new System.Windows.Forms.Button();
            this.btmostrar = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dueño:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raza:";
            // 
            // txtDueño
            // 
            this.txtDueño.Location = new System.Drawing.Point(142, 41);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(100, 20);
            this.txtDueño.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(142, 158);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(142, 209);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 7;
            // 
            // btagregar
            // 
            this.btagregar.Location = new System.Drawing.Point(321, 77);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(75, 23);
            this.btagregar.TabIndex = 8;
            this.btagregar.Text = "AGREGAR";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // btmostrar
            // 
            this.btmostrar.Location = new System.Drawing.Point(321, 141);
            this.btmostrar.Name = "btmostrar";
            this.btmostrar.Size = new System.Drawing.Size(75, 23);
            this.btmostrar.TabIndex = 9;
            this.btmostrar.Text = "MOSTRAR";
            this.btmostrar.UseVisualStyleBackColor = true;
            this.btmostrar.Click += new System.EventHandler(this.btmostrar_Click);
            // 
            // btsalir
            // 
            this.btsalir.Location = new System.Drawing.Point(321, 206);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(75, 23);
            this.btsalir.TabIndex = 10;
            this.btsalir.Text = "SALIR";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(197, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(440, 112);
            this.dataGridView1.TabIndex = 11;
            // 
            // FrmMiguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FORMULARIOS.Properties.Resources.animales_1200x700_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.btmostrar);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDueño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMiguel";
            this.Text = "FrmMiguel";
            this.Load += new System.EventHandler(this.FrmMiguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDueño;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Button btmostrar;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}