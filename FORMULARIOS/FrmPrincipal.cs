using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGianella callback = new FrmGianella();
            callback.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAddinT callback = new FrmAddinT();
            callback.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMary callback = new FrmMary();
            callback.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCleiner callback = new FrmCleiner();
            callback.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmYeison callback = new FrmYeison();
            callback.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMiguel callback = new FrmMiguel();
            callback.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnOmar_Click(object sender, EventArgs e)
        {
            FrmOmar callback = new FrmOmar();
            callback.Show();
        }
    }
}
