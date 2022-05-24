
namespace FORMULARIOS
{
    partial class FrmMary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkDni = new System.Windows.Forms.CheckBox();
            this.chkRuc = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCIÓN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELÉFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(489, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROVEEDOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtRubro);
            this.panel1.Controls.Add(this.txtRazon);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvLista);
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(54, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 632);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIPO DE DOCUMENTO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkDni);
            this.panel2.Controls.Add(this.chkRuc);
            this.panel2.Location = new System.Drawing.Point(242, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 47);
            this.panel2.TabIndex = 26;
            // 
            // chkDni
            // 
            this.chkDni.AutoSize = true;
            this.chkDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDni.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkDni.Location = new System.Drawing.Point(17, 16);
            this.chkDni.Name = "chkDni";
            this.chkDni.Size = new System.Drawing.Size(55, 20);
            this.chkDni.TabIndex = 24;
            this.chkDni.Text = "DNI";
            this.chkDni.UseVisualStyleBackColor = true;
            // 
            // chkRuc
            // 
            this.chkRuc.AutoSize = true;
            this.chkRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRuc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkRuc.Location = new System.Drawing.Point(93, 16);
            this.chkRuc.Name = "chkRuc";
            this.chkRuc.Size = new System.Drawing.Size(61, 20);
            this.chkRuc.TabIndex = 25;
            this.chkRuc.Text = "RUC";
            this.chkRuc.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Maroon;
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTelefono.Location = new System.Drawing.Point(447, 265);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(206, 22);
            this.txtTelefono.TabIndex = 23;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Maroon;
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtDireccion.Location = new System.Drawing.Point(447, 226);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(206, 22);
            this.txtDireccion.TabIndex = 22;
            // 
            // txtRubro
            // 
            this.txtRubro.BackColor = System.Drawing.Color.Maroon;
            this.txtRubro.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtRubro.Location = new System.Drawing.Point(447, 98);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(206, 22);
            this.txtRubro.TabIndex = 21;
            // 
            // txtRazon
            // 
            this.txtRazon.BackColor = System.Drawing.Color.Maroon;
            this.txtRazon.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtRazon.Location = new System.Drawing.Point(447, 63);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(206, 22);
            this.txtRazon.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "TELÉFONO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "DIRECCIÓN";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Maroon;
            this.txtId.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtId.Location = new System.Drawing.Point(447, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 22);
            this.txtId.TabIndex = 16;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Location = new System.Drawing.Point(735, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(216, 54);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Maroon;
            this.btnAgregar.Location = new System.Drawing.Point(735, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(216, 54);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.Maroon;
            this.txtNumero.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNumero.Location = new System.Drawing.Point(447, 168);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(206, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "NRO. DOCUMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "RUBRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAZÓN SOCIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDPROVEEDOR";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.DIRECCIÓN,
            this.TELÉFONO});
            this.dgvLista.Location = new System.Drawing.Point(32, 334);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(1117, 249);
            this.dgvLista.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RAZÓN_SOCIAL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RUBRO";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TIPO_DOCUMENTO";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NRO. _DOCUMENTO";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // DIRECCIÓN
            // 
            this.DIRECCIÓN.HeaderText = "DIRECCIÓN";
            this.DIRECCIÓN.MinimumWidth = 6;
            this.DIRECCIÓN.Name = "DIRECCIÓN";
            this.DIRECCIÓN.ReadOnly = true;
            // 
            // TELÉFONO
            // 
            this.TELÉFONO.HeaderText = "TELÉFONO";
            this.TELÉFONO.MinimumWidth = 6;
            this.TELÉFONO.Name = "TELÉFONO";
            this.TELÉFONO.ReadOnly = true;
            // 
            // FrmMary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 804);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMary";
            this.Text = "FrmMary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkDni;
        private System.Windows.Forms.CheckBox chkRuc;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCIÓN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELÉFONO;
    }
}