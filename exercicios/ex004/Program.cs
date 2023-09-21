class Metodo{
    public static void Main(){
        Console.WriteLine("Digiteum numero");
        int nrDigitado = int.Parse(Console.ReadLine());
        Dobro(nrDigitado);
        Metade(nrDigitado);
         }
        
        public static void  Dobro (int n){
          Console.WriteLine(n * 2);
        }
        
        public static void Metade(int n){
          Console.WriteLine(n / 2);
        }
        }

        int num = 5;
        int contador = 1;

        while(contador <= 10)
        {
            Console.WriteLine($"{contador}º execucao: {num} x {contador} = {num * contador}");
        }
    
