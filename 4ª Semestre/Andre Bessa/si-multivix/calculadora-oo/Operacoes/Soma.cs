using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_oo.Operacoes
{
    internal class Soma : Operacao
    {
        public Soma(double valor1, double valor2) : base(valor1, valor2)
        {
        }

        public override double Calcular(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }
}
