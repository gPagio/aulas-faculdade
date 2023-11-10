using controle_de_tarefas.Utils;
using System.Text.RegularExpressions;

namespace controle_de_tarefas
{
    internal class Controller
    {
        public static HashSet<TaskModel> tasks = new();

        public void AdicionarTarefa(String task, DateTime taskCreationDate)
        {
            tasks.Add(new TaskModel(task, taskCreationDate));
        }

        public IEnumerable<TaskModel> BuscarTarefa(Guid idTask)
        {
            foreach (TaskModel task in tasks)
            {
                if (task.GetIdTask().Equals(idTask))
                {
                    yield return task;
                }
            }
        }

        public IEnumerable<TaskModel> BuscarTarefa(String nameTask)
        {
            foreach (TaskModel task in tasks)
            {
                if (task.GetNameTask().Equals(nameTask))
                {
                    yield return task;
                }
            }
        }

        public IEnumerable<TaskModel> BuscarTarefa(DateTime taskCreationDate)
        {
            foreach (TaskModel task in tasks)
            {
                if (task.GetDataCriacao().Equals(taskCreationDate))
                {
                    yield return task;
                }
            }
        }

        public void RemoverTarefaId(String idTask)
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

        public void RemoverTarefaNome(String nameTask)
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

        public void RemoverTarefaData(String data)
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

        public void ListarTarefasCadastradas()
        {
            foreach (TaskModel item in tasks)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
