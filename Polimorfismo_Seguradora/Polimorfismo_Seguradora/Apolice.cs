using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Seguradora
{
    public class Apolice
    {

        public int NumeroAp { get; set; }
        public int CodSeguradora { get; set; }
        public DateTime Data { get; set; }
        public double ValorPremio { get; set; }
        public double ValorBem { get; set; }

        public double CalcularApolice(float valorVeiculo, int parcela)
        {
            return valorVeiculo = ((valorVeiculo / parcela) * 100) / 5;
        }

        public double CalcularApolice(double valorImovel, int parcela)
        {
            return valorImovel = ((valorImovel / 10) * 100) / 1;
        }

    }


}
