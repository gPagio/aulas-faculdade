namespace app_alunos
{
    internal class Program
    {

        static Aluno[] alunos = new Aluno[5];
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void CadastraAluno()
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write($"Digite o nome do {i + 1} aluno");
                alunos[i].nome = Console.ReadLine()!;
                
                Console.Write($"Digite o CPF do {i + 1} aluno");
                alunos[i].cpf = Console.ReadLine()!;
                
                Console.Write($"Digite o email do {i + 1} aluno");
                alunos[i].email = Console.ReadLine()!;
                
                Console.Write($"Digite o curso do {i + 1} aluno");
                alunos[i].curso = Console.ReadLine()!;
            }
        }

        void ListarAlunos()
        {
            foreach(var aluno in alunos)
            {
                Console.WriteLine($"Nome = {aluno.nome}");
                Console.WriteLine($"Email = {aluno.email}");
                Console.WriteLine($"CPF = {aluno.cpf}");
                Console.WriteLine($"Curso = {aluno.curso}");
            }
        }

        public struct Aluno
        {
            public string cpf;
            public string nome;
            public string email;
            public string curso;
        }
    }
}