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
    public partial class Carro : Form
    {
        public Carro()
        {
            InitializeComponent();
        }

        ApoliceCarro C = new ApoliceCarro();


        private void btnVerificar_Click(object sender, EventArgs e)
        {

            float ValorCarro;
            int NumParcelas;
            double parcelas;

            ValorCarro = float.Parse(txtValorApolice.Text);
            NumParcelas = int.Parse(txtValorBem.Text);
            parcelas = C.CalcularApolice(ValorCarro, NumParcelas);

            C.NumeroAp = int.Parse(txtNumApolice.Text);
            C.NumVistoria = int.Parse(txtNumVistoria.Text);
            C.Quilometragem = double.Parse(txtQuilometragem.Text);
            C.Modelo = txtModelo.Text;
            C.Marca = txtMarca.Text;
            C.Placa = txtPlaca.Text;
            C.Renavam = txtRenavam.Text;
            C.ValorPremio = double.Parse(txtValorPremio.Text);
            C.Data = DateTime.Parse(DTime.Text);
            C.DataVistoria = DateTime.Parse(DTimeVistoria.Text);
            C.CodSeguradora = int.Parse(txtCodSeguranca.Text);
            C.AnoFabricacao = int.Parse(txtAnoFabricacao.Text);

            MessageBox.Show("Quilometragem: " + C.Quilometragem + "\n Modelo: " + C.Modelo + "\n Marca: " + C.Marca + "\n Placa: " + C.Placa + "\n Renavam: " + C.Renavam + "\n Valor do Prêmio: " + C.ValorPremio + "\n Valor das parcelas: " + parcelas);
        }

        private void Carro_Load(object sender, EventArgs e)
        {

        }
    }
}
