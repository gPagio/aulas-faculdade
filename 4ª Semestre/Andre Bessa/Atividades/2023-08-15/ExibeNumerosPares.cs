public class ExibeNumerosPares {
    public static void ExibirNumerosPares (String[] args) {

        Console.Clear();

        Console.WriteLine(Menu.menuPrincipalOpcaoQuatro.Substring(6));
        Console.WriteLine ("Os números pares de 0 a 20 são: ");
        for (int i = 0; i < 20; i++) {
            if (i%2 == 0) {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("");
    }
}
