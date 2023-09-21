using SistemaBancario.Models;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bem-vindo ao Tezzon.Bank");

        Console.WriteLine("Digite o nome do titular:");
        string titular = Console.ReadLine();
        Contacorrente conta = new Contacorrente(titular, 0);

        string opcao = "";

        do
        {
            Console.WriteLine("#########MENU######");
            Console.WriteLine("1-Consultar saldo");
            Console.WriteLine("2-Depositar");
            Console.WriteLine("3-Sacar");
            Console.WriteLine("0- Sair");


            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado,volte sempre!!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    conta.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite um valor");
                    decimal valorTezzon = decimal.Parse(Console.ReadLine());  
                    conta.Depositar(valorTezzon);
                    break;
                case "3":
                    Console.WriteLine("Digite um valor");
                    decimal valorTezzon2 = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorTezzon2);
                    break;
                default:
                    Console.WriteLine("Opcao invalida!!");
                    break;
            }

        } while (opcao != "0");

    }

}