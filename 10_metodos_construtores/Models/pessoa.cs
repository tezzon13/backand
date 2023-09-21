namespace Models
{
    public class Pessoa
    {
        // atributos da classe pessoa
        private string nome { get; set; }
        private int idade { get; set; }

        // criando metodo construtor
        public Pessoa (string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        // metodo da classe pessoa 
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }
    }
}