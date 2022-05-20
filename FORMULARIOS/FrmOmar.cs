using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//activarse using

namespace FORMULARIOS
{
    public partial class FrmOmar : Form
    {
        public FrmOmar()
        {
            InitializeComponent();
        }

        SqlConnection  conex = new SqlConnection("Data Source=MIKES;Initial Catalog=mikeAndGiane;Integrated Security=True");
        private void FrmOmar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mikeAndGianeDataSet.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.mikeAndGianeDataSet.personas);
            // TODO: esta línea de código carga datos en la tabla 'mikeAndGianeDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.mikeAndGianeDataSet.productos);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter.FillBy(this.mikeAndGianeDataSet.productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlCommand Insertar = new SqlCommand("insert into productos values(@productid,@productame,@unitprice,@stock)", conex);
            conex.Open();
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Insertar.Parameters.Clear();
                    Insertar.Parameters.AddWithValue("@productid",Convert.ToInt32(row.Cells["Column1"]));
                    Insertar.Parameters.AddWithValue("@prodctnamee", Convert.ToString(row.Cells["Column2"]));
                    Insertar.Parameters.AddWithValue("@unitprice", Convert.ToDouble(row.Cells["Column3"]));
                    Insertar.Parameters.AddWithValue("@stock", Convert.ToInt32(row.Cells["Column4"]));
                    Insertar.ExecuteNonQuery();
                    MessageBox.Show("datos agregados");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("error al insertar");

            }
            finally
            {
                conex.Close();
            }
            
        }
    }
}
