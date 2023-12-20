using controle_de_tarefas.Utils;

namespace controle_de_tarefas
{
    internal class Controller
    {
        public static HashSet<TaskModel> tasks = new();

        public static void AdicionarTarefa()
        {

            Console.Clear();
            Console.WriteLine(MenuMessages.opcao1MenuPrincipal);
            Console.Write("Insira o nome da tarefa: ");

            //Nome tarefa
            String nomeTarefa = null!;
            while (String.IsNullOrEmpty(nomeTarefa))
            {
                nomeTarefa = Console.ReadLine()!.ToString();
                if (String.IsNullOrEmpty(nomeTarefa))
                {
                    Console.Clear();
                    Console.WriteLine(MenuMessages.opcao1MenuPrincipal);
                    Console.WriteLine("O nome da tarefa não pode ficar vazio!");
                    Console.Write("Insira o nome da tarefa: ");
                }
            }

            //Data entrega tarefa
            Console.Clear();
            Console.WriteLine(MenuMessages.opcao1MenuPrincipal);
            Console.Write($"Insira a data de entrega para a tarefa {nomeTarefa}: ");
            String dataEntregaTarefa = null!;
            while (String.IsNullOrEmpty(dataEntregaTarefa))
            {
                dataEntregaTarefa = Console.ReadLine()!.ToString();
                if (String.IsNullOrEmpty(dataEntregaTarefa))
                {
                    Console.Clear();
                    Console.WriteLine(MenuMessages.opcao1MenuPrincipal);
                    Console.WriteLine("A data de entrega da tarefa não pode ficar vazia!");
                    Console.WriteLine("Insira a data de entrega da tarefa");
                }
                else if (!String.IsNullOrEmpty(dataEntregaTarefa))
                {
                    TimeSpan validaDataEntrega = DateTime.Parse(dataEntregaTarefa!).Subtract(DateTime.Now);
                    if (validaDataEntrega.Days < 0)
                    {
                        Console.Clear();
                        Console.WriteLine(MenuMessages.opcao1MenuPrincipal);
                        Console.WriteLine("A data de entrega não pode ser menor que a data atual");
                        Console.WriteLine("");
                        Console.WriteLine("Insira uma data no formato DD/MM/YYYY e que seja maior que a data atual");
                        dataEntregaTarefa = null!;
                    }
                }
            }

            tasks.Add(new TaskModel(nomeTarefa, DateTime.Parse(dataEntregaTarefa)));
 
            Console.Clear();
            Console.WriteLine("Tarefa cadastrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static IEnumerable<TaskModel> BuscarTarefa(Guid idTask)
        {
            foreach (TaskModel task in tasks)
            {
                if (task.GetIdTask().Equals(idTask))
                {
                    yield return task;
                }
            }
        }

        public static IEnumerable<TaskModel> BuscarTarefa(String nameTask)
        {
            foreach (TaskModel task in tasks)
            {
                if (task.GetNameTask().Equals(nameTask))
                {
                    yield return task;
                }
            }
        }

        public static IEnumerable<TaskModel> BuscarTarefa(DateTime taskCreationDate)
        {
            foreach (TaskModel task in tasks)
            {
                if (task.GetDataCriacao().Equals(taskCreationDate))
                {
                    yield return task;
                }
            }
        }

        public static void RemoverTarefaId(String idTask)
        {

            Guid id = Guid.Parse(idTask);
            bool removeuTarefa = false;
            foreach (TaskModel task in tasks)
            {
                TaskModel? taskParaRemover = null;
                if (task.GetIdTask().Equals(idTask))
                {
                    taskParaRemover = task;
                }

                if (taskParaRemover != null)
                {
                    tasks.Remove(taskParaRemover);
                    removeuTarefa = true;
                }
            }

            if (!removeuTarefa)
            {
                Console.Clear();
                Console.WriteLine("Nenhuma tarefa foi removida pois o ID informado não foi encontrado...");
            }
            else
            {
                Console.WriteLine("Tarefa removida com sucesso!");
            }
        }

        public static void RemoverTarefaNome(String nameTask)
        {
            bool removeuTarefa = false;
            foreach (TaskModel task in tasks)
            {
                TaskModel? taskParaRemover = null;
                if (task.GetNameTask().Equals(nameTask.ToLower()))
                {
                    taskParaRemover = task;
                }

                if (taskParaRemover != null)
                {
                    tasks.Remove(taskParaRemover);
                    removeuTarefa = true;
                }
            }

            if (!removeuTarefa)
            {
                Console.Clear();
                Console.WriteLine("Nenhuma tarefa foi removida pois o nome informado não foi encontrado...");
            }
            else
            {
                Console.WriteLine("Tarefa removida com sucesso!");
            }
        }

        public static void RemoverTarefaData(String data)
        {
            while (RegexData.ValidaFormatoDataSimples(data) == false)
            {
                Console.WriteLine("Formato de data não suportado");
                Console.WriteLine("Insira uma data no formato DD/MM/YYYY");
                data = Console.ReadLine()!;
            };

            DateTime dataParaRemover = DateTime.Parse(data);

            bool removeuTarefa = false;
            foreach (TaskModel task in tasks)
            {
                TaskModel? taskParaRemover = null;
                if (task.GetDataCriacao().Equals(dataParaRemover))
                {
                    taskParaRemover = task;
                }

                if (taskParaRemover != null)
                {
                    tasks.Remove(taskParaRemover);
                    removeuTarefa = true;
                }
            }

            if (!removeuTarefa)
            {
                Console.Clear();
                Console.WriteLine("Nenhuma tarefa foi removida pois a data informada não foi encontrada...");
            }
            else
            {
                Console.WriteLine("Tarefa removida com sucesso!");
            }
        }

        public static void ListarTarefasCadastradas()
        {
            foreach (TaskModel item in tasks)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
