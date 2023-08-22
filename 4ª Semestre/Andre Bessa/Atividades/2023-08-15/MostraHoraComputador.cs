
public class MostraHoraComputador{
    public static void MostrarDataHora(String[] args) {
        
        Console.Clear();

        Console.WriteLine(Menu.menuPrincipalOpcaoTres.Substring(6));
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual.ToString());
        Console.WriteLine("");
    }
}