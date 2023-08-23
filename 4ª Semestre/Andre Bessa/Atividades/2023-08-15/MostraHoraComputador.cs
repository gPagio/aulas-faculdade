
public class MostraHoraComputador{
    public static void MostrarDataHora(String[] args) {
        
        Console.Clear();

        Console.WriteLine(Menu.menuPrincipalOpcaoTres.Substring(6));
        Console.WriteLine(DateTime.Now.ToString()); /*Retorna data e hora do sistema pela função estática da classe DateTime*/
        Console.WriteLine("");
    }
}