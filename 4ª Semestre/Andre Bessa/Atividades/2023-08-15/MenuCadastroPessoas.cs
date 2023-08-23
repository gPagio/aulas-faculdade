using System.Collections;
using System.Text.RegularExpressions;

public class MenuCadastroPessoas{
    public static void CadastrarPessoa(string[] args){
        var opcao = "0";
        int contador;

        /*Opcoes do menu de cadastro de pessoas*/
        string opcaoMenuCadastroUm = "(1) - Cadastrar";
        string opcaoMenuCadastroDois = "(2) - Listar";
        string opcaoMenuCadastroTres = "(3) - Mais Velho";
        string opcaoMenuCadastroQuatro = "(4) - Sair";

        Console.Clear();

        ArrayList nomePessoa = new();
        ArrayList idadePessoa = new();

        /*Usa mesma lógica do menu principal da classe Menu*/
        while(opcao != "4"){
            while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4"){
                Console.WriteLine(Menu.menuPrincipalOpcaoUm.Substring(6));
                
                /*Usa mesma lógica para exibir mensagem de opcao invalida*/
                if (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4"){
                    Console.WriteLine(Menu.menuPrincipalOpcaoUm.Substring(6));
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Escolha entre as opções listadas no menu abaixo:");
                    Console.WriteLine("");
                }

                /*Mostra menu do sistema de cadastro de pessoas*/
                Console.WriteLine(opcaoMenuCadastroUm);
                Console.WriteLine(opcaoMenuCadastroDois);
                Console.WriteLine(opcaoMenuCadastroTres);
                Console.WriteLine(opcaoMenuCadastroQuatro);
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine()!;

                /*Chama a funcao de acordo com a opcao escolhida. Ao final da execucao de cada case opcao volta a ser 0 para que entre no loop while novamente*/
                switch (opcao){
                    case "1":
                        string nomeParaAdicionar;
                        string idadeParaAdicionar;
                        string patternNome = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b"; /*Utilização de expressoes regulares (Regex) para validacao dos inputs do terminal*/
                        string patternIdade = @"\b[0-9]+\b";                 /*Utilização de expressoes regulares (Regex) para validacao dos inputs do terminal*/
                        bool nomeValido = false;
                        bool idadeValida = false;

                        Console.Clear();
                        Console.WriteLine(Menu.menuPrincipalOpcaoUm.Substring(6));
                        Console.WriteLine(opcaoMenuCadastroUm);
                        while(nomeValido == false){
                            Console.Write("Digite o nome: ");
                            nomeParaAdicionar = Console.ReadLine()!;
                            nomeValido = Regex.IsMatch(nomeParaAdicionar,patternNome); /*Compara o nome a regex pertinente a ele. Se atender a regra retorna true, se não retorna false*/

                            /*Trata nome digitado invalido, retornando o input para inserir novo nome*/
                            if (nomeValido == false){
                                Console.WriteLine("Nome inválido!");
                                Console.WriteLine("O nome deve ter nome e sobrenome, ambos iniciados com letra maiúscula");
                                Console.WriteLine("");
                            } else {
                                nomePessoa.Add(nomeParaAdicionar); /*Adiciona o nome caso nome seja valido, ou seja, condicao do if seja falsa*/
                                Console.WriteLine("");
                            }
                        }

                        while(idadeValida == false){
                            Console.Write("Digite a idade: ");
                            idadeParaAdicionar = Console.ReadLine()!;
                            idadeValida = Regex.IsMatch(idadeParaAdicionar, patternIdade); /*Compara a idade a regex pertinente a ela. Se atender a regra retorna true, se não retorna false*/

                            /*Trata idade digitada invalida, retornando o input para inserir nova idade*/
                            if (idadeValida == false){
                                Console.WriteLine("Idade inválida!");
                                Console.WriteLine("A idade deve conter apenas numeros inteiros");
                                Console.WriteLine("");
                            } else {
                                idadePessoa.Add(Convert.ToInt32(idadeParaAdicionar)); /*Adiciona a idade caso idade seja valida, ou seja, condicao do if seja falsa*/
                                Console.WriteLine("");
                            }
                        }

                        opcao = "0";
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine(Menu.menuPrincipalOpcaoUm.Substring(6));
                        Console.WriteLine(opcaoMenuCadastroDois);

                        contador = 0;
                        if (nomePessoa.Count == 0){ /*Verifica o tamanho do array para mostrar se array está vazio*/
                            Console.WriteLine("Sem registros!");
                        } else {
                            while(contador < nomePessoa.Count){ /*Lista todos as pessoas cadastradas caso tenha conteudo no array, ou seja, quantidade de itens maior que 0*/
                                Console.WriteLine("Nome: " + nomePessoa[contador]!.ToString() + ", idade: " + idadePessoa[contador]!.ToString());
                                contador++;
                            }
                        }
                        Console.WriteLine("");

                        opcao = "0";
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine(Menu.menuPrincipalOpcaoUm.Substring(6));
                        Console.WriteLine(opcaoMenuCadastroTres);

                        contador = 0;
                        if (nomePessoa.Count == 0){ /*Verifica o tamanho do array para mostrar se array está vazio*/
                            Console.WriteLine("Sem registros!");
                        } else {
                            while(contador < nomePessoa.Count){ /*Lista todos as pessoas cadastradas caso tenha conteudo no array, ou seja, quantidade de itens maior que 0*/
                                if(Convert.ToInt32(idadePessoa[contador]) == MaiorIdade(idadePessoa)){
                                    Console.WriteLine("Nome: " + nomePessoa[contador]!.ToString() + ", idade: " + idadePessoa[contador]!.ToString());
                                }
                                contador++;
                            }
                        }
                        Console.WriteLine("");

                        opcao = "0";
                        break;
                    
                    case "4":
                            Console.Clear();
                            Console.WriteLine(Menu.menuPrincipalOpcaoUm.Substring(6));
                            Console.WriteLine(opcaoMenuCadastroQuatro);
                            Console.WriteLine("Obrigado por usar nosso sistema de cadastro de pessoas!");
                            Console.WriteLine("");
                        break;
                }
            }
        }
    }

    public static int MaiorIdade (ArrayList idadePessoa){           /*Funcao para retornar qual o valor da maior idade*/
        idadePessoa.Sort();                                         /*Ordena o array em ordem descrescente*/
        return Convert.ToInt32(idadePessoa[idadePessoa.Count - 1]); /*Retorna a ultima posicao*/
    }
}