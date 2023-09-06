using System.Data;

public class Cadastro {

struct Produto {

        int codigo;
        String nome;
        Double preco;

        public Produto (int codigo, String nome, Double preco){
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
        }


    }

    public static void cadastraProduto (){
        Console.WriteLine("Digite o código do produto");
        
        
        Console.WriteLine("Digite o nome do produto");
        Console.WriteLine("Digite o preço do produto");

    }

    public static void listaCadastro(){

    }

}