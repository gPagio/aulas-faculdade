
public class MostraHoraComputador{
    public static void MostrarHora(String[] args) {
        DateTime dataAtual = DateTime.Now;
        
        Console.WriteLine(dataAtual.ToString());
    }
}