using System.IO;
public class Program
{
    public static void Main()
    {
       gravarArquivo();
    }

    public static void gravarArquivo()
    {
        try
       {
         using (StreamWriter arquivo = new StreamWriter("arquivo.txt", true))
         {
            arquivo.WriteLine("Queride");4
         }
       }
       catch (Exception erro)
       {
        Console.WriteLine($"Ocorreu um erro no arquivo{erro.Message}");
       }
    }
}