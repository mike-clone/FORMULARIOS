
namespace FORMULARIOS
{
    partial class FrmOmar
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
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mikeAndGianeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mikeAndGianeDataSet = new FORMULARIOS.mikeAndGianeDataSet();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtProductid = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTablaToolStrip = new System.Windows.Forms.ToolStrip();
            this.consultaTablaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productosTableAdapter = new FORMULARIOS.mikeAndGianeDataSetTableAdapters.productosTableAdapter();
            this.personasTableAdapter = new FORMULARIOS.mikeAndGianeDataSetTableAdapters.personasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource3)).BeginInit();
            this.consultaTablaToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.mikeAndGianeDataSetBindingSource;
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
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this.mikeAndGianeDataSetBindingSource;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "productos";
            this.productosBindingSource1.DataSource = this.mikeAndGianeDataSetBindingSource;
            // 
            // txtProductid
            // 
            this.txtProductid.Location = new System.Drawing.Point(84, 102);
            this.txtProductid.Name = "txtProductid";
            this.txtProductid.Size = new System.Drawing.Size(100, 22);
            this.txtProductid.TabIndex = 10;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(532, 102);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 11;
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Location = new System.Drawing.Point(380, 102);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(100, 22);
            this.txtUnitprice.TabIndex = 12;
            // 
            // txtProductname
            // 
            this.txtProductname.Location = new System.Drawing.Point(234, 102);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(100, 22);
            this.txtProductname.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(690, 411);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "productid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "productname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "unitPrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "stock";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(550, 335);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 36);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataMember = "productos";
            this.productosBindingSource2.DataSource = this.mikeAndGianeDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productosBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(52, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 142);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 125;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unitprice";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unitprice";
            this.unitpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            this.unitpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // productosBindingSource3
            // 
            this.productosBindingSource3.DataMember = "productos";
            this.productosBindingSource3.DataSource = this.mikeAndGianeDataSetBindingSource;
            // 
            // consultaTablaToolStrip
            // 
            this.consultaTablaToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.consultaTablaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaTablaToolStripButton});
            this.consultaTablaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.consultaTablaToolStrip.Name = "consultaTablaToolStrip";
            this.consultaTablaToolStrip.Size = new System.Drawing.Size(800, 27);
            this.consultaTablaToolStrip.TabIndex = 21;
            this.consultaTablaToolStrip.Text = "consultaTablaToolStrip";
            // 
            // consultaTablaToolStripButton
            // 
            this.consultaTablaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consultaTablaToolStripButton.Name = "consultaTablaToolStripButton";
            this.consultaTablaToolStripButton.Size = new System.Drawing.Size(103, 24);
            this.consultaTablaToolStripButton.Text = "consultaTabla";
            this.consultaTablaToolStripButton.Click += new System.EventHandler(this.consultaTablaToolStripButton_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.consultaTablaToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtProductname);
            this.Controls.Add(this.txtUnitprice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtProductid);
            this.Name = "FrmOmar";
            this.Text = "Omar";
            this.Load += new System.EventHandler(this.FrmOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource3)).EndInit();
            this.consultaTablaToolStrip.ResumeLayout(false);
            this.consultaTablaToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mikeAndGianeDataSetBindingSource;
        private mikeAndGianeDataSet mikeAndGianeDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private mikeAndGianeDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private mikeAndGianeDataSetTableAdapters.personasTableAdapter personasTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private System.Windows.Forms.TextBox txtProductid;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.BindingSource productosBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource3;
        private System.Windows.Forms.ToolStrip consultaTablaToolStrip;
        private System.Windows.Forms.ToolStripButton consultaTablaToolStripButton;
    }
}