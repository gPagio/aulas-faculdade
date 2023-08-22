
public class MostraHoraComputador{
    public static void MostrarDataHora(String[] args) {
        DateTime dataAtual = DateTime.Now;
        
        Console.WriteLine(dataAtual.ToString());
        Console.WriteLine("");
    }
}