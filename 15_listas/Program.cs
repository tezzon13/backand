using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
        //criando uma lista de numeros inteiros

        List<int> listaNumeros = new List<int>();

        //Adicionando elementos á lista 
        listaNumeros.Add(10);  // posição [0]
        listaNumeros.Add(20);  // posição [1]
        listaNumeros.Add(45);  // posição [2]

        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        //Contando a quantidade de elementos em nossa lista 
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        // Acessando os dados da lista pelo indice 

        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(8); // posição [3]
         Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

         Console.WriteLine("------------------------------------");


         // Criem uma nova lista de nomes e adicionem alguns  nomes a ela e exibam a quantidade de nomes que contem nessa lista

        List<string> listaNomes = new List<string>();

        listaNomes.Add("Ana Clara");
        listaNomes.Add("Tezzon");  
        listaNomes.Add("Dantas");  

        Console.WriteLine($"Neste momento temos {listaNomes.Count} nomes");

         foreach (string item in listaNomes)
        {
            Console.WriteLine(item);                                                                                       
        }

        Console.WriteLine("------------------------------------");

        //Criando uma lista atribuindo valores 

        List<int> numeros = new List<int> {1,2,3,4,5,6,7,8,9};
        numeros.Add(10);

        //Iternando sobre todos os itens da lista

           numeros.Remove(2); // remove o elemento  pelo conteudo
           numeros.RemoveAt(4); // remove pela posição
           numeros.RemoveRange(2, 2); // remove o elemento da posição dois e os proximos dois 

        foreach (int item in numeros)
        {
            Console.WriteLine(item);                                                                                       
        }

        // criando uma nova lista com objetos da Classe aluno7
        List<Aluno> listaAlunos = new List<Aluno>();

        // Adicionando um novo aluno a listaAluno
        Aluno novoAluno = new Aluno("Marcos",15);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Cesar",17));

        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome aluno: {item.nome}  idade {item.idade}");
        }

       var consulta = from aluno in listaAlunos
            where aluno.idade > 18
            orderby aluno.nome
            select aluno;
            Console.WriteLine("Lista de alunos maiores de 18 anos ");
            foreach ( var item in consulta)
            {
                Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
            }
          
          // LINQ ultilizando Sintaxe de metodo
       
       var metodo = listaAlunos
                             . Where(novoAluno => aluno.idade < 18)
                             . orderby(novoAluno => aluno.nome);
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
        }
        
    }
}