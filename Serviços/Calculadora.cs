using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havan_Projeto.Serviços
{
    public class Calculadora
    {
        public static Calculadora _service;

        public static Calculadora Instance()
        {
            if (_service == null)
                _service = new Calculadora();

            return _service;
        }

        public double ValorConvertido(float valorMoedaOriginal,
            float valorMoedaFinal, float valorReal)
        {
            double valorConversao = (valorMoedaOriginal / valorMoedaFinal) * valorReal;
            valorConversao = Math.Round(valorConversao, 2);

            return valorConversao;
        }

        public double ValorTaxa(float valorFinal)
        {
            double valorFinalTaxa = valorFinal * 0.10f;
            valorFinalTaxa = Math.Round(valorFinalTaxa, 2);

            return valorFinalTaxa;
        }
    }
}
