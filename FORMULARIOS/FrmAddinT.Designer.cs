namespace FORMULARIOS
{
    partial class FrmAddinT
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
            this.btnmostar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btactualizar = new System.Windows.Forms.Button();
            this.btagregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aDDINDataSet = new FORMULARIOS.ADDINDataSet();
            this.aDDINDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmostar
            // 
            this.btnmostar.Location = new System.Drawing.Point(572, 260);
            this.btnmostar.Name = "btnmostar";
            this.btnmostar.Size = new System.Drawing.Size(105, 23);
            this.btnmostar.TabIndex = 56;
            this.btnmostar.Text = "MOSTRAR";
            this.btnmostar.UseVisualStyleBackColor = true;
            this.btnmostar.Click += new System.EventHandler(this.btnmostar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(463, 260);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(84, 23);
            this.btneliminar.TabIndex = 54;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btactualizar
            // 
            this.btactualizar.Location = new System.Drawing.Point(306, 260);
            this.btactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(99, 23);
            this.btactualizar.TabIndex = 53;
            this.btactualizar.Text = "ACTUALIZAR";
            this.btactualizar.UseVisualStyleBackColor = true;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // btagregar
            // 
            this.btagregar.Location = new System.Drawing.Point(122, 260);
            this.btagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(125, 23);
            this.btagregar.TabIndex = 52;
            this.btagregar.Text = "AGREGAR";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "DIRECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "DESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "RUC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "CODIGO ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "NEGOCIOS";
            // 
            // txtdirec
            // 
            this.txtdirec.Location = new System.Drawing.Point(725, 145);
            this.txtdirec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(193, 22);
            this.txtdirec.TabIndex = 45;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(517, 145);
            this.txtdes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(160, 22);
            this.txtdes.TabIndex = 44;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(361, 145);
            this.txtruc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(127, 22);
            this.txtruc.TabIndex = 43;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(211, 145);
            this.txtnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(133, 22);
            this.txtnom.TabIndex = 42;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(81, 145);
            this.txtcod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 22);
            this.txtcod.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 232);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aDDINDataSet
            // 
            this.aDDINDataSet.DataSetName = "ADDINDataSet";
            this.aDDINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDDINDataSetBindingSource
            // 
            this.aDDINDataSetBindingSource.DataSource = this.aDDINDataSet;
            this.aDDINDataSetBindingSource.Position = 0;
            // 
            // FrmAddinT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FORMULARIOS.Properties.Resources.Paltas;
            this.ClientSize = new System.Drawing.Size(977, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnmostar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdirec);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtcod);
            this.Name = "FrmAddinT";
            this.Text = "FrmAddinT";
            this.Load += new System.EventHandler(this.FrmAddinT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDINDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmostar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ADDINDataSet aDDINDataSet;
        private System.Windows.Forms.BindingSource aDDINDataSetBindingSource;
    }
}