namespace controle_de_tarefas
{
    internal class Program
    {
        static void Main(String[] args)
        {

            String? opcaoSeletoraMenuPrincipal = null;

            while (opcaoSeletoraMenuPrincipal! == null)
            {
                Console.WriteLine("BEM VINDO AO GERENCIADOS DE TAREFAS 2000");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma função: ");
                Console.WriteLine(MenuMessages.opcao1MenuPrincipal);
                Console.WriteLine(MenuMessages.opcao2MenuPrincipal);
                Console.WriteLine(MenuMessages.opcao3MenuPrincipal);
                Console.WriteLine(MenuMessages.opcao4MenuPrincipal);
                Console.WriteLine(MenuMessages.opcao5MenuPrincipal);
                opcaoSeletoraMenuPrincipal = Console.ReadLine()!.ToString();

                switch (opcaoSeletoraMenuPrincipal)
                {
                    case "1":
                        Controller.AdicionarTarefa();                        
                        opcaoSeletoraMenuPrincipal = null;
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine(MenuMessages.opcao2MenuPrincipal);

                        String opcaoSeletoraCase2 = null!;
                        while (opcaoSeletoraCase2 == null)
                        {
                            Console.WriteLine("Escolha como deseja remover a tarefa: ");
                            Console.WriteLine(MenuMessages.opcao1MenuRemoverTarefa);
                            Console.WriteLine(MenuMessages.opcao2MenuRemoverTarefa);
                            Console.WriteLine(MenuMessages.opcao3MenuRemoverTarefa);
                            Console.WriteLine(MenuMessages.opcao4MenuRemoverTarefa);
                            opcaoSeletoraCase2 = Console.ReadLine()!.ToString();

                            switch (opcaoSeletoraCase2)
                            {
                                case "1":
                                    Console.WriteLine("Insira o ID da tarefa a ser removida");
                                    Controller.RemoverTarefaId(Console.ReadLine()!);
                                    opcaoSeletoraCase2 = null!;
                                    break;

                                case "2":
                                    Console.WriteLine("Insira o nome da tarefa a ser removida");
                                    Controller.RemoverTarefaNome(Console.ReadLine()!);
                                    opcaoSeletoraCase2 = null!;
                                    break;

                                case "3":
                                    Console.WriteLine("Insira a data de criação da tarefa a ser removida");
                                    Controller.RemoverTarefaData(Console.ReadLine()!);
                                    opcaoSeletoraCase2 = null!;
                                    break;
                                case "4":
                                    Console.Clear();
                                    Console.WriteLine("Voltando ao menu principal...");
                                    Thread.Sleep(2000);
                                    break;
                                default:
                                    Console.WriteLine("Opção não disponível, escolha uma opção presente no menu!");
                                    opcaoSeletoraCase2 = null!;
                                    break;
                            }
                        }
                        opcaoSeletoraMenuPrincipal = null;
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine(MenuMessages.opcao3MenuPrincipal);
                        Controller.ListarTarefasCadastradas();
                        opcaoSeletoraMenuPrincipal = null;
                        break;

                    case "4":
                        opcaoSeletoraMenuPrincipal = null;
                        break;
                    case "5":
                        Console.WriteLine("Obrigado por usar nossa aplicação!");
                        Console.WriteLine("Volte Sempre!");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção não disponível, escolha uma opção presente no menu!");
                        Thread.Sleep(2000);
                        opcaoSeletoraMenuPrincipal = null;
                        break;
                }
            }
        }
    }
}