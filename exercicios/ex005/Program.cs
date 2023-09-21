class ex005
{
    public static void Main()
    {
        ListaDoChurrasco();
    }

    public static void ListaDoChurrasco()
    {
        string[] listaProdutos = new string[6];


        listaProdutos[0] = "carne 3kg";
        for (int i = 0; i < listaProdutos.Length; i++)
        {
              Console.WriteLine("informe o produto:");
        string produto = Console.ReadLine();
        listaProdutos[i] = produto;
        }

      
    }

    Array.Sort(listaProdutos);


foreach (string item in listaProdutos)
{
    Console.WriteLine($"Item {item}");
}

public static void SonhoDeConsumo(){
    string[] listaSonhos = new string[3]
}

 }