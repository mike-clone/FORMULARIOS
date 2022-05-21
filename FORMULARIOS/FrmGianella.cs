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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
 
            using(SqlConnection cn = new SqlConnection("Data Source=LAPTOP-TIFHNC74\SQLEXPRESS;Initial Catalog=mikeAndGiane;Integrated Security=True"))
                (
                 Sql
                 )
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
