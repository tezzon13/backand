class Sesi
{
    public static void Main()
    {
        Console.WriteLine("Estou no metodo Main");
        Metodo();
        ImprimeTadaHora();
        ImprimeTadaHora();

        int resultadoSoma = Somar(3,8);
        Console.WriteLine(resultadoSoma);

        ContagemRegressiva(8);

    }

    public static void Metodo(){
        Console.WriteLine("Estou no metodo / funcao");
    }
    public static void ImprimeTadaHora(){
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.Hour.ToString());
        Console.WriteLine(DateTime.Now.ToString());
    }

    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
        
    }

    public static void ContagemRegressiva(int n)
    {
        while(n>= 0){
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(1000);
        }
    }
}

