using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Seguradora
{
    public class ApoliceCarro : Apolice
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }
        public int AnoFabricacao { get; set; }
        public double Quilometragem { get; set; }
        public int NumVistoria { get; set; }
        public DateTime DataVistoria { get; set; }


    }
}
