using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havan_Projeto.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string MoedaOriginal { get; set; }
        public string MoedaDestino { get; set; }
        public string DataOperacao { get; set; }
        public string ValorOriginal { get; set; }
        public string ValorConvertido { get; set; }
        public string TaxaCobrada { get; set; }
    }
}
