using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Seguradora
{
    public class ApoliceResidencia : Apolice
    {

        public string Endereco { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }


    }
}
