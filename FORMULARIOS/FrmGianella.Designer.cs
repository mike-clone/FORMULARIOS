
namespace FORMULARIOS
{
    partial class FrmGianella
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtapellidopat = new System.Windows.Forms.TextBox();
            this.txtapellidomat = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mikeAndGianeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mikeAndGianeDataSet = new FORMULARIOS.mikeAndGianeDataSet();
            this.addinDataSet1 = new FORMULARIOS.ADDINDataSet();
            this.mikeAndGianeDataSet1 = new FORMULARIOS.mikeAndGianeDataSet1();
            this.mikeAndGianeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new FORMULARIOS.mikeAndGianeDataSet1TableAdapters.personasTableAdapter();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.personasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter1 = new FORMULARIOS.mikeAndGianeDataSetTableAdapters.personasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.Location = new System.Drawing.Point(407, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 22);
            this.txtNombre.TabIndex = 34;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtdireccion.Location = new System.Drawing.Point(285, 189);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(355, 22);
            this.txtdireccion.TabIndex = 33;
            // 
            // txtapellidopat
            // 
            this.txtapellidopat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtapellidopat.Location = new System.Drawing.Point(285, 91);
            this.txtapellidopat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtapellidopat.Name = "txtapellidopat";
            this.txtapellidopat.Size = new System.Drawing.Size(355, 22);
            this.txtapellidopat.TabIndex = 32;
            // 
            // txtapellidomat
            // 
            this.txtapellidomat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtapellidomat.Location = new System.Drawing.Point(285, 146);
            this.txtapellidomat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtapellidomat.Name = "txtapellidomat";
            this.txtapellidomat.Size = new System.Drawing.Size(355, 22);
            this.txtapellidomat.TabIndex = 31;
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtdni.Location = new System.Drawing.Point(77, 39);
            this.txtdni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(161, 22);
            this.txtdni.TabIndex = 30;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Red;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(664, 25);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(158, 36);
            this.btnInsertar.TabIndex = 29;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "DIRECCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "APELLIDO MATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "APELLIDO PATERNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "DNI";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(664, 161);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 34);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Red;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(664, 65);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(158, 32);
            this.btnMostrar.TabIndex = 37;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 264);
            this.dataGridView1.TabIndex = 39;
            // 
            // mikeAndGianeDataSetBindingSource
            // 
            this.mikeAndGianeDataSetBindingSource.DataSource = this.mikeAndGianeDataSet;
            this.mikeAndGianeDataSetBindingSource.Position = 0;
            // 
            // mikeAndGianeDataSet
            // 
            this.mikeAndGianeDataSet.DataSetName = "mikeAndGianeDataSet";
            this.mikeAndGianeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addinDataSet1
            // 
            this.addinDataSet1.DataSetName = "ADDINDataSet";
            this.addinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mikeAndGianeDataSet1
            // 
            this.mikeAndGianeDataSet1.DataSetName = "mikeAndGianeDataSet1";
            this.mikeAndGianeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mikeAndGianeDataSet1BindingSource
            // 
            this.mikeAndGianeDataSet1BindingSource.DataSource = this.mikeAndGianeDataSet1;
            this.mikeAndGianeDataSet1BindingSource.Position = 0;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this.mikeAndGianeDataSet1BindingSource;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(664, 112);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 34);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // personasBindingSource1
            // 
            this.personasBindingSource1.DataMember = "personas";
            this.personasBindingSource1.DataSource = this.mikeAndGianeDataSetBindingSource;
            // 
            // personasTableAdapter1
            // 
            this.personasTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmGianella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FORMULARIOS.Properties.Resources.buyer_persona;
            this.ClientSize = new System.Drawing.Size(866, 685);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellidopat);
            this.Controls.Add(this.txtapellidomat);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGianella";
            this.Text = "Gianella";
            this.Load += new System.EventHandler(this.FrmGianella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtapellidopat;
        private System.Windows.Forms.TextBox txtapellidomat;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
        private ADDINDataSet addinDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mikeAndGianeDataSetBindingSource;
        private mikeAndGianeDataSet mikeAndGianeDataSet;
        private System.Windows.Forms.BindingSource mikeAndGianeDataSet1BindingSource;
        private mikeAndGianeDataSet1 mikeAndGianeDataSet1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private mikeAndGianeDataSet1TableAdapters.personasTableAdapter personasTableAdapter;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.BindingSource personasBindingSource1;
        private mikeAndGianeDataSetTableAdapters.personasTableAdapter personasTableAdapter1;
    }
}