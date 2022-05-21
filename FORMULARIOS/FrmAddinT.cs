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
    public partial class FrmAddinT : Form
    {
        public FrmAddinT()
        {
            InitializeComponent();
        }
        string conexion = "Data Source=DESKTOP-RL2KS61\\SQLEXPRESS;Initial Catalog=ADDIN;Integrated Security=True";

        private void btagregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NEGOCIO (CODIGO,NOMBRE, RUC,DESCRIPCION,direccion) VALUES (" + int.Parse(txtcod.Text) + ",'" + txtnom.Text + "'," + Convert.ToDouble(txtruc.Text) + ",'" + txtdes.Text + "',   '"+ txtdirec.Text + "')", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            txtcod.Text = "";
            txtnom.Text = "";
            txtruc.Text = "";
            txtdes.Text = "";
            txtdirec.Text = "";


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

        private void btactualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("update negocio set nombre = '" + txtnom.Text + "', ruc =" + Convert.ToDouble(txtruc.Text) + ", descripcion = '" + txtdes.Text + "', direccion =  '" + txtdirec.Text + "' where codigo =" + int.Parse(txtcod.Text) + "", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            txtcod.Text = "";
            txtnom.Text = "";
            txtruc.Text = "";
            txtdes.Text = "";
            txtdirec.Text = "";


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
            txtdirec.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose(); 
        }

        private void FrmAddinT_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
