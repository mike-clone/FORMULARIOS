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
    public partial class FrmGianella : Form
    {
        public FrmGianella()
        {
            InitializeComponent();
        }
        string conexion = "Data Source=LAPTOP-TIFHNC74\\SQLEXPRESS;Initial Catalog=mikeAndGiane;Integrated Security=True";

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            using (SqlConnection giane = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("insert into personas(dni, Nombre, apellidopat, apellidomat, direccion) values (" + int.Parse(txtdni.Text) + ",'" + txtNombre.Text + "','" + txtapellidopat.Text + "','" + txtapellidomat.Text + "','"+ txtdireccion.Text+"')", giane);
                cmd.CommandType = CommandType.Text;
                giane.Open();
                cmd.ExecuteNonQuery();
            }
            txtdni.Text = "";
            txtNombre.Text = "";
            txtapellidopat.Text = "";
            txtapellidomat.Text = "";
            txtdireccion.Text = "";

            DataTable dt = new DataTable();
            using (SqlConnection giane = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from personas ", giane);
                da.SelectCommand.CommandType = CommandType.Text;
                giane.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection giane = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from personas ", giane);
                da.SelectCommand.CommandType = CommandType.Text;
                giane.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void FrmGianella_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mikeAndGianeDataSet1.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.mikeAndGianeDataSet1.personas);

        }
    }
}
