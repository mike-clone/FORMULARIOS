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
    public partial class FrmMiguel : Form
    {
        public FrmMiguel()
        {
            InitializeComponent();
        }
        string conexion = "Data Source=DESKTOP-M06SUE5\\SQLEXPRESS;Initial Catalog=MIGUEL;Integrated Security=True";



        private void btagregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection mig = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("insert into animales (dueño,nombre,edad,raza) values ('" + txtDueño.Text + "','" + txtNombre.Text + "'," + int.Parse(txtEdad.Text) + ",'" + txtRaza.Text + "')", mig);
                cmd.CommandType = CommandType.Text;
                mig.Open();
                cmd.ExecuteNonQuery();
            }
            txtDueño.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtRaza.Text = "";


            DataTable dt = new DataTable();
            using (SqlConnection mig = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from animales ", mig);
                da.SelectCommand.CommandType = CommandType.Text;
                mig.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        private void FrmMiguel_Load(object sender, EventArgs e)
        {

        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection mig = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from animales ", mig);
                da.SelectCommand.CommandType = CommandType.Text;
                mig.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }


}
