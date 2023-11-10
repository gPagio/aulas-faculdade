using System.Collections;

namespace controle_de_tarefas
{
    internal class TaskModel : IEnumerable<TaskModel>
    {
        private Guid idTarefa;
        private String nomeTarefa;
        private DateTime dataEntregaTarefa;

        public TaskModel(String nameTask, DateTime taskCreationDate)
        {
            this.idTarefa = Guid.NewGuid();
            this.nomeTarefa = nameTask.ToLower();
            this.dataEntregaTarefa = taskCreationDate;
        }

        public Guid GetIdTask()
        {
            return this.idTarefa;
        }

        public String GetNameTask()
        {
            return this.nomeTarefa;
        }

        public DateTime GetDataCriacao()
        {
            return this.dataEntregaTarefa;
        }

        public String GetDataCriacaoFormatada()
        {
            return this.dataEntregaTarefa.ToString("dd/MM/yyyy");
        }

        public int GetDiasRestantes()
        {
            TimeSpan periodoRestante = this.GetDataCriacao().Subtract(DateTime.Now);
            return periodoRestante.Days;
        }

        public override String ToString()
        {
            return "ID da Tarefa: " + idTarefa.ToString() + "\n Nome da Tarefa: " + nomeTarefa.ToString() + "\n Data de Entrega: " + dataEntregaTarefa.ToString() + "\n Dias Restantes: " + this.GetDiasRestantes() + "\n";
        }

        public IEnumerator<TaskModel> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
