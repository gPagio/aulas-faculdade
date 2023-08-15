using System.Runtime.Serialization;

namespace app_calculadora;
internal class Program
{
    static void Main(string[] args)
    {
        double valor1;
        double valor2;
        var opcao = 0;

        Console.WriteLine("Insira Valor 1: ");
        valor1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("");

        Console.WriteLine("Insira Valor 2: ");
        valor2 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("");


        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("[+] Soma");
        Console.WriteLine("[-] Subtração");
        Console.WriteLine("[*] Multiplicação");
        Console.WriteLine("[/] Divisão");

        while(opcao != '+' && opcao != '-' && opcao != '*' && opcao != '/')
        {
            Console.WriteLine("Digite a opção: ");
            opcao = Console.ReadLine()![0];
            Console.WriteLine("");
        }

        switch (opcao)
        {
            case '+':
                double _soma = Soma(valor1, valor2);
                Console.WriteLine("A soma é: " + _soma);
                Console.WriteLine("");
                break;

            case '-':
                double _sub = Subtracao(valor1, valor2);
                Console.WriteLine("A subtracao é: " + _sub);
                Console.WriteLine("");
                break;

            case '*':
                double _mul = Multiplicacao(valor1, valor2);
                Console.WriteLine("A multiplicacao é: " + _mul);
                Console.WriteLine("");
                break;

            case '/':
                double _div = Divisao(valor1, valor2);
                Console.WriteLine("A divisao é: " + _div);
                Console.WriteLine("");
                break;
        }
    }

    private static double Soma(double valor1, double valor2)
    {
        return valor1 + valor2;
    }
    private static double Subtracao(double valor1, double valor2)
    {
        return valor1 - valor2;
    }
    private static double Multiplicacao(double valor1, double valor2)
    {
        return valor1 * valor2;
    }
    private static double Divisao(double valor1, double valor2)
    {
        return valor1 / valor2;
    }
}