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

        public void RemoverTarefa(Guid idTask)
        {
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
                }
            }
        }

        public void RemoverTarefa(String nameTask)
        {
            foreach (TaskModel task in tasks)
            {
                TaskModel? taskParaRemover = null;
                if (task.GetNameTask().Equals(nameTask))
                {
                    taskParaRemover = task;
                }

                if (taskParaRemover != null)
                {
                    tasks.Remove(taskParaRemover);
                }
            }
        }

        public void RemoverTarefa(DateTime taskCreationDate)
        {
            foreach (TaskModel task in tasks)
            {
                TaskModel? taskParaRemover = null;
                if (task.GetDataCriacao().Equals(taskCreationDate))
                {
                    taskParaRemover = task;
                }

                if (taskParaRemover != null)
                {
                    tasks.Remove(taskParaRemover);
                }
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
