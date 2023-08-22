public class Menu{
    public static void Main(String[] args) {
        var opcao = "0";
        string menuPrincipalOpcaoUm = "(1) - Sistema de Cadastro de Pessoas";
        string menuPrincipalOpcaoTres = "(3) - Mostrar Data e Hora do Sistema";
        string menuPrincipalOpcaoQuatro = "(4) - Exibe Números Pares de 0 a 20 Usando Loop For";
        string menuPrincipalOpcaoSeis = "(6) - Exibe Números Ímpares no Intervalo Informado Pelo Usuário";
        string menuPrincipalOpcaoSete = "(7) - Sair";
        
        Console.WriteLine("Seja bem vindo a atividade de LP1, dia 15/08/2023");

        while(opcao != "1" && opcao != "3" && opcao != "4" && opcao != "6" && opcao != "7") {
            if (opcao != "0" && opcao != "1" && opcao != "3" && opcao != "4" && opcao != "6" && opcao != "7"){
                Console.WriteLine("");
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("Escolha entre as opções listadas no menu abaixo:");
            }

            Console.WriteLine("Escolha um exercício nos menus abaixo para testar:");
            Console.WriteLine(menuPrincipalOpcaoUm);
            Console.WriteLine(menuPrincipalOpcaoTres);
            Console.WriteLine(menuPrincipalOpcaoQuatro);
            Console.WriteLine(menuPrincipalOpcaoSeis);
            Console.WriteLine(menuPrincipalOpcaoSete);
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine(menuPrincipalOpcaoUm);
                    MenuCadastroPessoas.CadastrarPessoa(args);
                    opcao = "0";
                    break;

                case "3":
                    Console.WriteLine("");
                    Console.WriteLine(menuPrincipalOpcaoTres);
                    MostraHoraComputador.MostrarDataHora(args);
                    opcao = "0";
                    break;

                case "4":
                    Console.WriteLine("");
                    Console.WriteLine(menuPrincipalOpcaoQuatro);
                    ExibeNumerosPares.ExibirNumerosPares(args);
                    opcao = "0";
                    break;

                case "6":
                    Console.WriteLine("");
                    Console.WriteLine(menuPrincipalOpcaoSeis);
                    ExibeNumerosImpares.ExibirNumerosImpares(args);
                    opcao = "0";
                    break;

                case "7":
                    Console.WriteLine("");
                    Console.WriteLine(menuPrincipalOpcaoSete);
                    Console.WriteLine("Obrigado por usar nosso programa");
                    break;
            }
        }
    }
}