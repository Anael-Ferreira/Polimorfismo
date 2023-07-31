using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo_Seguradora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            Carro C = new Carro();
            C.ShowDialog();
        }

        private void btnResidencia_Click(object sender, EventArgs e)
        {
            Residencia R = new Residencia();
            R.ShowDialog();
        }
    }
}
