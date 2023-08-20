using System.Collections;
using System.Text.RegularExpressions;

public class NumeroUm{
    
    public static void Main(string[] args){
    
        var opcao = "0";
        int contador = 0;

        ArrayList nomePessoa = new();
        ArrayList idadePessoa = new();

        while(opcao != "4"){
            while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4"){
                Console.WriteLine("(1) - Cadastrar");
                Console.WriteLine("(2) - Listar");
                Console.WriteLine("(3) - Mais Velho");
                Console.WriteLine("(4) - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine()!;

                switch (opcao){
                    case "1":
                        string nomeParaAdicionar;
                        int idadeParaAdicionar;
                        string patternNome = @"\b[A-Za-zÀ-ÿ]+(?:[-'\s][A-Za-zÀ-ÿ]+)*\b";
                        string patternIdade = @"^[0-9]+$";
                        bool nomeValido = false;
                        bool idadeValida = false;

                        Console.WriteLine(" ");
                        Console.WriteLine("(1) - Cadastrar");
                        while(nomeValido == false){
                            Console.Write("Digite o nome: ");
                            nomeParaAdicionar = Console.ReadLine()!;
                            nomeValido = Regex.IsMatch(nomeParaAdicionar,patternNome);

                            if (nomeValido == false){
                                Console.WriteLine("Nome inválido!");
                            } else {
                                nomePessoa.Add(nomeParaAdicionar);
                                Console.WriteLine("");
                            }
                        }

                        while(idadeValida == false){
                            Console.Write("Digite a idade: ");
                            idadeParaAdicionar = Convert.ToInt32(Console.ReadLine());
                            idadeValida = Regex.IsMatch(idadeParaAdicionar.ToString(), patternIdade);

                            if (idadeValida == false){
                                Console.WriteLine("Idade inválida!");
                            } else {
                                idadePessoa.Add(idadeParaAdicionar);
                                Console.WriteLine("");
                            }
                        }

                        opcao = "0";
                        break;

                    case "2":
                        Console.WriteLine(" ");
                        Console.WriteLine("(2) - Listar");

                        contador = 0;
                        while(contador < nomePessoa.Count){
                            Console.WriteLine("Nome: " + nomePessoa[contador]!.ToString() + ", idade: " + idadePessoa[contador]!.ToString());
                            contador++;
                        }
                        Console.WriteLine(" ");

                        opcao = "0";
                        break;

                    case "3":
                        Console.WriteLine(" ");
                        Console.WriteLine("(3) - Mais Velho");

                        contador = 0;
                        while(contador < nomePessoa.Count){
                            if(Convert.ToInt32(idadePessoa[contador]) == MaiorIdade(idadePessoa)){
                                Console.WriteLine("Nome: " + nomePessoa[contador]!.ToString() + ", idade: " + idadePessoa[contador]!.ToString());
                            }
                            contador++;
                        }
                        Console.WriteLine(" ");

                        opcao = "0";
                        break;
                    
                    default:
                        if(opcao == "4"){
                              Console.WriteLine("Obrigado por usar nosso programa");
                        }
                        break;
                }
            }
        }
    }

    public static int MaiorIdade (ArrayList idadePessoa){
        idadePessoa.Sort();
        return Convert.ToInt32(idadePessoa[idadePessoa.Count - 1]);
    }
}