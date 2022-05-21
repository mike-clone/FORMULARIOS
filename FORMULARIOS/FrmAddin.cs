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
    public partial class FrmAddin : Form
    {
        public FrmAddin()
        {
            InitializeComponent();
        }
        string conexion = "Data Source=DESKTOP-RL2KS61\\SQLEXPRESS;Initial Catalog = ADDIN; Integrated Security = True";
        private void txtdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("update negocio set nombre = '" + txtnom.Text + "', ruc =" + Convert.ToDouble(txtruc.Text) + ", descripcion = '" + txtdes.Text + "', fecha = '" + DateTime.Parse(txtfech.Text) + "' where codigo =" + int.Parse(txtcod.Text) + "", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            txtcod.Text = "";
            txtnom.Text = "";
            txtruc.Text = "";
            txtdes.Text = "";
            txtfech.Text = "";
            

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NEGOCIO ", con);
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
          
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NEGOCIO (CODIGO,NOMBRE, RUC,DESCRIPCION,FECHA) VALUES (" + int.Parse(txtcod.Text) + ",'" + txtnom.Text + "'," + Convert.ToDouble(txtruc.Text) + ",'" + txtdes.Text + "', '" + DateTime.Parse(txtfech.Text) + "')", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            txtcod.Text = "";
            txtnom.Text = "";
            txtruc.Text = "";
            txtdes.Text = "";
            txtfech.Text = "";
           

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NEGOCIO ", con);
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        
      

private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand(" delete NEGOCIO  where codigo = " + int.Parse(txtcod.Text), con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            txtcod.Text = "";
            txtnom.Text = "";
            txtruc.Text = "";
            txtdes.Text = "";
            txtfech.Text = "";
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NEGOCIO ", con);
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void txtfech_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtruc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmAddin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aDDINDataSet.NEGOCIO' Puede moverla o quitarla según sea necesario.
            this.nEGOCIOTableAdapter.Fill(this.aDDINDataSet.NEGOCIO);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmostar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NEGOCIO ", con);   
                da.SelectCommand.CommandType = CommandType.Text;
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
