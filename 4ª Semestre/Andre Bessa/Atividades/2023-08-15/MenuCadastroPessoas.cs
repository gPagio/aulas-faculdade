using System.Collections;
using System.Text.RegularExpressions;

public class MenuCadastroPessoas{
    
    public static void Main(string[] args){
    
        var opcao = "0";
        int contador;

        ArrayList nomePessoa = new();
        ArrayList idadePessoa = new();

        while(opcao != "4"){
            while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4"){
                if (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4"){
                    Console.WriteLine(" ");
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Escolha entre as opções listadas no menu abaixo:");
                }
                Console.WriteLine("(1) - Cadastrar");
                Console.WriteLine("(2) - Listar");
                Console.WriteLine("(3) - Mais Velho");
                Console.WriteLine("(4) - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine()!;

                switch (opcao){
                    case "1":
                        string nomeParaAdicionar;
                        string idadeParaAdicionar;
                        string patternNome = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
                        string patternIdade = @"\b[0-9]+\b";
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
                                Console.WriteLine("O nome deve ter nome e sobrenome, ambos iniciados com letra maiúscula");
                                Console.WriteLine(" ");
                            } else {
                                nomePessoa.Add(nomeParaAdicionar);
                                Console.WriteLine(" ");
                            }
                        }

                        while(idadeValida == false){
                            Console.Write("Digite a idade: ");
                            idadeParaAdicionar = Console.ReadLine()!;
                            idadeValida = Regex.IsMatch(idadeParaAdicionar, patternIdade);

                            if (idadeValida == false){
                                Console.WriteLine("Idade inválida!");
                                Console.WriteLine("A idade deve conter apenas numeros inteiros");
                                Console.WriteLine(" ");
                            } else {
                                idadePessoa.Add(Convert.ToInt32(idadeParaAdicionar));
                                Console.WriteLine("");
                            }
                        }

                        opcao = "0";
                        break;

                    case "2":
                        Console.WriteLine(" ");
                        Console.WriteLine("(2) - Listar");

                        contador = 0;
                        if (nomePessoa.Count == 0){
                            Console.WriteLine("Sem registros!");
                        } else {
                            while(contador < nomePessoa.Count){
                                Console.WriteLine("Nome: " + nomePessoa[contador]!.ToString() + ", idade: " + idadePessoa[contador]!.ToString());
                                contador++;
                            }
                        }
                        Console.WriteLine(" ");

                        opcao = "0";
                        break;

                    case "3":
                        Console.WriteLine(" ");
                        Console.WriteLine("(3) - Mais Velho");

                        contador = 0;
                        if (nomePessoa.Count == 0){
                            Console.WriteLine("Sem registros!");
                        } else {
                            while(contador < nomePessoa.Count){
                                if(Convert.ToInt32(idadePessoa[contador]) == MaiorIdade(idadePessoa)){
                                    Console.WriteLine("Nome: " + nomePessoa[contador]!.ToString() + ", idade: " + idadePessoa[contador]!.ToString());
                                }
                                contador++;
                            }
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