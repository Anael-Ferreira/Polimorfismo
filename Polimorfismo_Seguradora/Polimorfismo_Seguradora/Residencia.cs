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
    public partial class Residencia : Form
    {
        public Residencia()
        {
            InitializeComponent();
        }

        ApoliceResidencia R = new ApoliceResidencia();

        private void Residencia_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            double Valor, Resultado;
            int Parcelas;

            Valor = double.Parse(txtValorApolice.Text);
            Parcelas = int.Parse(txtValorBem.Text);
            Resultado = R.CalcularApolice(Valor, Parcelas);

            R.Endereco = txtEndereco.Text;
            R.UF = txtUF.Text;
            R.CEP = int.Parse(txtCEP.Text);
            R.Bairro = txtBairro.Text; 
            R.Cidade = txtCidade.Text;
            R.Municipio = txtMunicipio.Text;
            R.NumeroAp = int.Parse(txtNumApolice.Text);
            R.CodSeguradora = int.Parse(txtCodSeguranca.Text);
            R.Data = DateTime.Parse(DTime.Text);
            R.ValorPremio = double.Parse(txtValorPremio.Text);

            MessageBox.Show("Endereço: " + R.Endereco + "\n UF: " + R.UF + "\n CEP: " + R.CEP + "\n Bairro: " + R.Bairro + "\n Cidade: " + R.Cidade + "\n Valor do Prêmio: " + R.ValorPremio + "\n Valor das parcelas: " + Resultado);
        }
    }
}
