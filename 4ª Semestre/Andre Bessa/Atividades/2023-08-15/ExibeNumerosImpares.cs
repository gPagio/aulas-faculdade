public class ExibeNumerosImpares {
    public static void ExibirNumerosImpares(String[] args) {
        int contador;
        int primeiroValor;
        int segundoValor;

        Console.Clear();

        Console.WriteLine(Menu.menuPrincipalOpcaoSeis.Substring(6));
        Console.Write("Insira o primeiro valor do intervalo: ");
        primeiroValor = Convert.ToInt32(Console.ReadLine());    /*Recebe o primeiro valor*/

        Console.Write("Insira o segundo valor do intervalo: ");
        segundoValor = Convert.ToInt32(Console.ReadLine());     /*Recebe o segundo valor*/

        Console.WriteLine("");
        Console.WriteLine($"Os números impares entre {primeiroValor} e {segundoValor} são: ");
        contador = primeiroValor;
        while (contador < segundoValor){        /*Faz um loop enquanto o contador é menor que o segundo valor (maior valor), do numero inicial*/
            if  (contador%2 > 0){               /*informado ao numero final informado, dividindo o contador por 2 e exibindo onde o resto é maior*/
                Console.WriteLine(contador);    /*que zero, ou seja, numero é impar*/
            }
            contador++;
        }
        Console.WriteLine("");
    }
}