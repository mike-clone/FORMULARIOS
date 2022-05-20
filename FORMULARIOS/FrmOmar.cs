using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        }
        String conexion = "Data Source=MIKES;Initial Catalog=mikeAndGiane;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(conexion);
            int id = Convert.ToInt32(txtProductid.Text);
            double precio = Convert.ToDouble( txtUnitprice.Text);
            int  stock = Convert.ToInt32(txtStock.Text);

            String cmd = "insert into productos values(" + id + ",'" + txtProductname.Text + "'," + precio + "," + stock + ");";
            cnn.Open();
                try
            {
                SqlCommand insertar = new SqlCommand(cmd, cnn);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Todo good");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }
            finally
            {
                cnn.Close();
            }
       
           
        }

        private void consultaTablaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter.consultaTabla(this.mikeAndGianeDataSet.productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
