
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOmar));
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mikeAndGianeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mikeAndGianeDataSet = new FORMULARIOS.mikeAndGianeDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.productosTableAdapter = new FORMULARIOS.mikeAndGianeDataSetTableAdapters.productosTableAdapter();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new FORMULARIOS.mikeAndGianeDataSetTableAdapters.personasTableAdapter();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
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
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton,
            this.toolStripButton1});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 27);
            this.fillByToolStrip.TabIndex = 9;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this.mikeAndGianeDataSetBindingSource;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(456, 292);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(181, 72);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
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
            this.dataGridView1.DataSource = this.productosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "productos";
            this.productosBindingSource1.DataSource = this.mikeAndGianeDataSetBindingSource;
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
            // FrmOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "FrmOmar";
            this.Text = "Omar";
            this.Load += new System.EventHandler(this.FrmOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikeAndGianeDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mikeAndGianeDataSetBindingSource;
        private mikeAndGianeDataSet mikeAndGianeDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private mikeAndGianeDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private mikeAndGianeDataSetTableAdapters.personasTableAdapter personasTableAdapter;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource1;
    }
}