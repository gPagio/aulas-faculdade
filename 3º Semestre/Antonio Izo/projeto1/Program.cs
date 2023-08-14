using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1{
    internal class Program{
        public static void Main(string[] args){
            /*
            int num1;
            Console.WriteLine("Entre com num 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + 2);                //soma

            Console.WriteLine("Entre com num 2");
            var num2 = Console.ReadLine();
            Console.WriteLine(num2 + 2);                //concatena
            Console.WriteLine(Convert.ToInt32(num2)+2); //soma

            string nome = "Guilherme";
            int nascimento = 2004;

            Console.WriteLine($"Olá {nome}, você tem aproximadamente {DateTime.Now.Year - nascimento} anos");
            

            //=================================================================================================
            inicio:
            Console.Clear();
            int nota1, nota2, nota3;

            Console.WriteLine("Entre com valor da nota 1");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com valor da nota 2");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com valor da nota 3");
            nota3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Desejta continuar realizando a digitação? (S/N)");
            string resposta = Console.ReadLine();

            if(resposta == "S"){
                goto inicio;
            }

            int idade = 18;
            //Console.WriteLine(idade >= 18 ? "Você é maior de idade!" : "Você é menor de idade!");


            //USO DO IF/ELSE
            if (idade >= 18){
                Console.WriteLine("Você é maior de idade!");
            }
            else if (idade >= 16){
                Console.WriteLine("Idade entre 18 e 16");
            }
            else{
                Console.WriteLine("Você é menor de idade!");
            }*/

            int mes = 2;

            switch (mes){
                case 1:
                    Console.WriteLine("O mês é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês é Março");
                    break;
                case 4:
                    Console.WriteLine("O mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido!");
                    break;
            }

            int numero = 1;
            while (numero == 1){

            }
        }
    }
}