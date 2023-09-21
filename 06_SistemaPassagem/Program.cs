﻿class Program
{
    public static string[] poltronas = new string[51];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao Busstezzon");
        Console.WriteLine("----------------");
        Console.WriteLine("Contamos com 50 lugares");
        Console.WriteLine("----------------------");
        Console.WriteLine("Digite 1 para entrar no sistema e o 0 para sair");

        Menu();

    }

    public static void Menu()
    {
        string opcao = "";

        do
        {
            Console.WriteLine("#########MENU######");
            Console.WriteLine("1-Comprar passagem");
            Console.WriteLine("2-Lugares disponiveis");
            Console.WriteLine("3-Encerrar");
            Console.WriteLine("4-Lista De Passageiros");


            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado,volte sempre!!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                    case "3":
                    QuantidadesDisponiveis();
                    break;
                    case "4":
                    ListaDePassageiros();
                    break;
                    


                    
                default:
                    Console.WriteLine("Opcao invalida!!");
                    break;
            }

        } while (opcao != "0");
    }

    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i} ª passagem.");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro");
            string nome = Console.ReadLine();
            MarcaPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcaPoltrona(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;
    }
    public static void PoltronasDisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponiveis");
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                Console.WriteLine($"Nº {i}");
            }
        }
    }

    public static void QuantidadesDisponiveis{
        for (){
            int total = 0;
            Console.WriteLine("Quantidades de poltronas disponiveis");
            for (int i =1; i <= 50; i++);{
                if(poltronas[i] == null){
                    total = total + 1;
                }
            }
            Console.WriteLine("Atualmente temos" + total + "poltronas disponiveis");
        }
    }
    public static void ListaDePassageiros(){
        for(int i = 1; i<= 50; i++){
            if (poltronas[i] == null){
                Console.WriteLine($"Nº {i}");
            }
        }
    }
}