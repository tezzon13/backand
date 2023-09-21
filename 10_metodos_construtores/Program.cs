using Models;

public class Program
{
     public static void Main()
     {
        // criar um objeto da classe pessoa
       //* var pessoal = new Pessoa();
       //* pessoal.nome = "Ana Clara";
       //* pessoal.idade = 16;

       //*Pessoal pessoal = new pessoa {
       // nome = "Douglas";
       //* idade = 28

       // instanciando um objeto com o metodo construtor
       Pessoa pessoa1 = new Pessoa("Alberto Roberto",16);
       Pessoa pessoa2 = new Pessoa("Julia Fernanda",17);
      Pessoa pessoa3 = new Pessoa("Rafaela lima",18);

        //Chamando o medoto cantar da class pessoa
        pessoa1.Cantar();
        pessoa2.Cantar();
        pessoa3.Cantar();
     }
}