using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO.Operacoes
{
    internal abstract class Operacao
    {
        private double valor1;
        private double valor2;

        public Operacao(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }
        public abstract double Calcular(double valor1, double valor2);
    }
}
