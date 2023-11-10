namespace controle_de_tarefas
{
    internal class Program
    {
        private static String opcao1MenuPrincipal = "1 - Adicionar tarefa";
        private static String opcao2MenuPrincipal = "2 - Remover tarefa";
        private static String opcao3MenuPrincipal = "3 - Listar todas as tarefas";
        private static String opcao4MenuPrincipal = "4 - Buscar tarefa específica";
        private static String opcao5MenuPrincipal = "5 - Sair";

        private static String opcao1MenuRemoverTarefa = "1 - ID: Remove apenas a tarefa com o ID informado";
        private static String opcao2MenuRemoverTarefa = "2 - Nome: Remove todas as tarefas com o nome informado";
        private static String opcao3MenuRemoverTarefa = "3 - Data: Remove todas as tarefas com a data informada";
        private static String opcao4MenuRemoverTarefa = "4 - Voltar ao menu principal";
        static void Main(string[] args)
        {
            Controller controller = new();
            String? opcaoSeletoraMenuPrincipal = null;

            while (opcaoSeletoraMenuPrincipal! == null)
            {
                Console.WriteLine("BEM VINDO AO GERENCIADOS DE TAREFAS 2000");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma função: ");
                Console.WriteLine(opcao1MenuPrincipal);
                Console.WriteLine(opcao2MenuPrincipal);
                Console.WriteLine(opcao3MenuPrincipal);
                Console.WriteLine(opcao4MenuPrincipal);
                Console.WriteLine(opcao5MenuPrincipal);
                opcaoSeletoraMenuPrincipal = Console.ReadLine()!.ToString();

                switch (opcaoSeletoraMenuPrincipal)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(opcao1MenuPrincipal);
                        Console.Write("Insira o nome da tarefa: ");

                        //Nome tarefa
                        String nomeTarefa = null!;
                        while (String.IsNullOrEmpty(nomeTarefa))
                        {
                            nomeTarefa = Console.ReadLine()!.ToString();
                            if (String.IsNullOrEmpty(nomeTarefa))
                            {
                                Console.Clear();
                                Console.WriteLine(opcao1MenuPrincipal);
                                Console.WriteLine("O nome da tarefa não pode ficar vazio!");
                                Console.Write("Insira o nome da tarefa: ");
                            }
                        }

                        //Data entrega tarefa
                        Console.Clear();
                        Console.WriteLine(opcao1MenuPrincipal);
                        Console.Write($"Insira a data de entrega para a tarefa {nomeTarefa}: ");
                        String dataEntregaTarefa = null!;
                        while (String.IsNullOrEmpty(dataEntregaTarefa))
                        {
                            dataEntregaTarefa = Console.ReadLine()!.ToString();
                            if (String.IsNullOrEmpty(dataEntregaTarefa))
                            {
                                Console.Clear();
                                Console.WriteLine(opcao1MenuPrincipal);
                                Console.WriteLine("A data de entrega da tarefa não pode ficar vazia!");
                                Console.WriteLine("Insira a data de entrega da tarefa");
                            }
                            else if (!String.IsNullOrEmpty(dataEntregaTarefa))
                            {
                                TimeSpan validaDataEntrega = DateTime.Parse(dataEntregaTarefa!).Subtract(DateTime.Now);
                                if (validaDataEntrega.Days < 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine(opcao1MenuPrincipal);
                                    Console.WriteLine("A data de entrega não pode ser menor que a data atual");
                                    Console.WriteLine("");
                                    Console.WriteLine("Insira uma data no formato DD/MM/YYYY e que seja maior que a data atual");
                                    dataEntregaTarefa = null!;
                                }
                            }
                        }
                        controller.AdicionarTarefa(nomeTarefa, DateTime.Parse(dataEntregaTarefa));
                        
                        Console.Clear();
                        Console.WriteLine("Tarefa cadastrada com sucesso!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        
                        opcaoSeletoraMenuPrincipal = null;
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine(opcao2MenuPrincipal);

                        String opcaoSeletoraCase2 = null!;
                        while (opcaoSeletoraCase2 == null)
                        {
                            Console.WriteLine("Escolha como deseja remover a tarefa: ");
                            Console.WriteLine(opcao1MenuRemoverTarefa);
                            Console.WriteLine(opcao2MenuRemoverTarefa);
                            Console.WriteLine(opcao3MenuRemoverTarefa);
                            Console.WriteLine(opcao4MenuRemoverTarefa);
                            opcaoSeletoraCase2 = Console.ReadLine()!.ToString();

                            switch (opcaoSeletoraCase2)
                            {
                                case "1":
                                    Console.WriteLine("Insira o ID da tarefa a ser removida");
                                    controller.RemoverTarefaId(Console.ReadLine()!);
                                    opcaoSeletoraCase2 = null!;
                                    break;

                                case "2":
                                    Console.WriteLine("Insira o nome da tarefa a ser removida");
                                    controller.RemoverTarefaNome(Console.ReadLine()!);
                                    opcaoSeletoraCase2 = null!;
                                    break;

                                case "3":
                                    Console.WriteLine("Insira a data de criação da tarefa a ser removida");
                                    controller.RemoverTarefaData(Console.ReadLine()!);
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
                        Console.WriteLine(opcao3MenuPrincipal);
                        controller.ListarTarefasCadastradas();
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