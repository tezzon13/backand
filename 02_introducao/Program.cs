// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Sejam bem vindos ");

//somente declaramos a varieavel como interia e nao atribuimos valor


// variavel do tipo interia atribuindo valor 5
int num2 = 5;

/// variavel tipo string 
string nomeAluno;
/// variavel verdadeiro ou falso 
bool resultado=true;

/// variavel casas decimais 
double cordenada = 1.80;
/// variavel do tipo decimal 
decimal valor = 1.80M ;

int idade = 16;
string nome = "ana clara";
Console.WriteLine($"Meu nome é {nome} e tenho {idade}");
Console.WriteLine("Em que cidade voce nasceu ?");
string cidade = Console.ReadLine();
Console.WriteLine($"Voce nasceu em {cidade}");
int novaIdade = idade + 5 ;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Voce nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");