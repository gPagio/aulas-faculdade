using System.Collections;
public class Teste{
    public static void Main(string [] args){
        int tamanhoArray;
        int numeroBuscado;
        int contador = 0;
        String quantidadeNumero;

        ArrayList numeros = new();

        Console.Write("Informe o tamanho da lista:\n");
        tamanhoArray = Convert.ToInt32(Console.ReadLine());

        if(tamanhoArray > 1){
            quantidadeNumero = "numeros";
        } else {
            quantidadeNumero = "numero";
        }

        Console.WriteLine($"Digite {tamanhoArray} {quantidadeNumero}:\n");

        while(numeros.Count < tamanhoArray){
            numeros.Add(Convert.ToInt32(Console.ReadLine()));
        }

        Console.Write("Escolha um número para buscar:\n");
        numeroBuscado = Convert.ToInt32(Console.ReadLine());

        while(contador < numeros.Count){
            if(numeros.IndexOf(numeros[contador]).Equals(numeroBuscado)){
                Console.WriteLine($"Numero encontrado na posicao {contador}\n");
                contador++;
            }
        }
    }
}