using System.Collections;
public class Teste{
    public static void Main(string [] args){
        int tamanhoArray;
        int numeroBuscado;
        int contador = 0;
        String quantidadeNumero;

        ArrayList numeros = new();

        Console.WriteLine("Informe o tamanho da lista:");
        tamanhoArray = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");

        if(tamanhoArray > 1){
            quantidadeNumero = "numeros";
        } else {
            quantidadeNumero = "numero";
        }

        Console.WriteLine($"Digite {tamanhoArray} {quantidadeNumero}:");

        while(numeros.Count < tamanhoArray){
            numeros.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine(" ");

        Console.WriteLine("Escolha um número para buscar:");
        numeroBuscado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");

        while(contador < numeros.Count){
            if(numeros[contador]!.Equals(numeroBuscado)){
                Console.WriteLine($"Numero encontrado na posicao {contador}");
            }
            contador++;
        }

    }
}