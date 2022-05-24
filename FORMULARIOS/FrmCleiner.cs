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
    public partial class FrmCleiner : Form
    {
        public FrmCleiner()
        {
            InitializeComponent();
            mostrar();
        }
        string conexion = "Data Source=DESKTOP-R0RTQRL;Initial Catalog=Cleiner;Integrated Security=True";
        void Limpiar()
        {
            txtCargoTra.Clear();
            txtCorreo.Clear();
            txtDireccionTra.Clear();
            txtDni.Clear();
            txtIdtra.Clear();
            txtNombTra.Clear();
            txtTelefonoTra.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("insert into Trabajador(IdTrabajador,dni ,Nom_Trabajador ,Cargo ,Direccion ,Correo ,Telefono) values(" + txtIdtra.Text + ",'" + txtDni.Text + "','" + txtNombTra.Text + "','" + txtCargoTra.Text + "','" + txtDireccionTra.Text + "','" + txtCorreo.Text + "','" + txtTelefonoTra.Text + "')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            Limpiar();
            mostrar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("update Trabajador set dni='" + txtDni.Text + "' ,Nom_Trabajador='" + txtNombTra.Text + "' ,Cargo='" + txtCargoTra.Text + "' ,Direccion='" + txtDireccionTra.Text + "' ,Correo='" + txtCorreo.Text + "' ,Telefono='" + txtTelefonoTra.Text + "'  where IdTrabajador=" + txtIdtra.Text + " ", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            Limpiar();
            mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("delete from Trabajador where IdTrabajador= " + txtIdtra.Text + "", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            Limpiar();
            mostrar();
        }

        void mostrar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlDataAdapter da = new SqlDataAdapter("select *from Trabajador", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmCleiner_Load(object sender, EventArgs e)
        {

        }
    }
}
