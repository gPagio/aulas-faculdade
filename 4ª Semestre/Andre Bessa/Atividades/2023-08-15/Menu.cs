public class Menu{
    public static void Main(String[] args) {
        var opcao = "0";

        while(opcao != "1" && opcao != "3" && opcao != "4" && opcao != "6") {
            if (opcao != "0" && opcao != "1" && opcao != "3" && opcao != "4" && opcao != "6"){
                Console.WriteLine(" ");
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("Escolha entre as opções listadas no menu abaixo:");
            }

            Console.WriteLine("Seja bem vindo a atividade de LP1, dia 15/08/2023");
            Console.WriteLine("Escolha uma opção nos menus abaixo:");
            Console.WriteLine("(1) - Sistema de Cadastro de Pessoas");
            Console.WriteLine("(3) - Mostrar Data e Hora do Sistema");
            Console.WriteLine("(4) - Exibe Números Pares de 0 a 20 Usando Loop For");
            Console.WriteLine("(6) - Exibe Números Ímpares no Intervalo Informado Pelo Usuário");
            Console.WriteLine("(7) - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    Console.WriteLine("");
                    MenuCadastroPessoas.CadastrarPessoa(args);
                    opcao = "0";
                    break;

                case "3":
                    Console.WriteLine("");
                    MostraHoraComputador.MostrarHora(args);
                    opcao = "0";
                    break;

                case "4":
                    Console.WriteLine("");
                    Console.WriteLine("Em construção");
                    opcao = "0";
                    break;

                case "6":
                    Console.WriteLine("");
                    Console.WriteLine("Em construção");
                    opcao = "0";
                    break;

                case "7":
                    Console.WriteLine("");
                    break;

                default:
                    Console.WriteLine("");
                    break;
            }
        }

    }
}