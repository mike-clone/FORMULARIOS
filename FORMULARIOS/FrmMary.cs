using System;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOS
{
    public partial class FrmMary : Form
    {
        public FrmMary()
        {
            InitializeComponent();
        }
        string conexion = "Data Source=LAPTOP-IDV1F06T;User ID=SYSTEM;Password=123456;Unicode=True";

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            DataGridViewRow modelo = new DataGridViewRow();
            modelo.CreateCells(dgvLista);

            modelo.Cells[0].Value = int.Parse(txtId.Text);
            modelo.Cells[1].Value = txtRazon.Text;
            modelo.Cells[2].Value = txtRubro.Text;
            if (chkDni.Checked == true)
            {
                modelo.Cells[3].Value = "DNI";
            }
            else
            {
                modelo.Cells[3].Value = "RUC";
            }
            modelo.Cells[3].Value = txtRubro.Text;
            modelo.Cells[4].Value = int.Parse(txtNumero.Text);
            modelo.Cells[5].Value = txtDireccion.Text;
            modelo.Cells[6].Value = int.Parse(txtTelefono.Text);

            dgvLista.Rows.Add(modelo);

            txtId.Text = "";
            txtRazon.Text = "";
            txtRubro.Text = "";
            txtNumero.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            chkDni.Checked = false || (chkRuc.Checked = false);

            using (OracleConnection cn = new OracleConnection(conexion))
            {
                OracleCommand cmd = new OracleCommand("insert into proveedor(IdProv, Raz_Social, Sector_Comercial, tipo_documento, num_documento, direccion, telefono, email) values(" + int.Parse(txtId.Text) + ", '" + txtRazon + "', '" + txtRubro + "', 'DNI ', " + int.Parse(txtNumero.Text) + ", '" + txtDireccion + "', " + int.Parse(txtTelefono.Text) + ")", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                dgvLista.Rows.Remove(dgvLista.CurrentRow);

            using (OracleConnection cn = new OracleConnection(conexion))
            {
                OracleCommand cmd = new OracleCommand("delete proveedor where idProv= " + int.Parse(txtId.Text), cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();

                cmd.ExecuteNonQuery();
            }

        }
    }
}
