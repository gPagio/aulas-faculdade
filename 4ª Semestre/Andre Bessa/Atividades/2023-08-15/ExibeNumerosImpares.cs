public class ExibeNumerosImpares {
    public static void ExibirNumerosImpares(String[] args) {
        int contador;
        int primeiroValor;
        int segundoValor;

        Console.Write("Insira o primeiro valor do intervalo: ");
        primeiroValor = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o segundo valor do intervalo: ");
        segundoValor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine($"Os números impares entre {primeiroValor} e {segundoValor} são: ");
        contador = primeiroValor;
        while (contador < segundoValor){
            if  (contador%2 > 0){
                Console.WriteLine(contador);
            }
            contador++;
        }
        Console.WriteLine("");
    }
}