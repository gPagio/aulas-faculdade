using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO.Operacoes
{
    internal class Multiplicacao : Operacao
    {
        public Multiplicacao(double valor1, double valor2) : base(valor1, valor2)
        {
        }

        public override double Calcular(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
    }
}
