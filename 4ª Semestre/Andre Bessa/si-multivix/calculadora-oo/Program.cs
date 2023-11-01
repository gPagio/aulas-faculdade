using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_oo
{
    internal class Program
    {
        public static double valor1;
        public static double valor2;
        public static void Main(String[] args)
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("");

            Console.WriteLine("Informe 1º Num:");
            valor1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe 2º Num:");
            valor2 = double.Parse(Console.ReadLine()!);
        }
    }
}
