// CAULCULANDO A MEDIA DOS ALUNOS 
// RECEBER O NOME DO ALUNO E ARMAZENAR EM UMA VARIAVEL DO TIPO STRING 

Console.WriteLine("Informe o nome do aluno:");
string aluno = Console.ReadLine();
// RECEBER A NOTA 1 CONVERTER E ARMAZENAR NA VARIAVEL INT 
Console.WriteLine("Digite a nota 1 :");
int notal = int.Parse(Console.ReadLine());

// RECEBER A NOTA 2 CONVERTER E ARMAZENAR NA VARIAVEL INT 
Console.WriteLine("Digite a nota 2:");
int notal = int.Parse(Console.ReadLine());
// RECEBER A NOTA 3 CONVERTER E ARMAZENAR NA VARIAVEL INT 
Console.WriteLine("Digite a nota 3:");
int notal = int.Parse(Console.ReadLine());
// DECLARAR UMA VARIAVEL DO TIPO INT PARA RECEBER A MEDIA DAS NOTAS 
int media = ( nota1 + nota2 + nota3) / 3 
// EXIBIR UMA MENSAGEM SE O ALUNO ESTA APROVADO CONSIDERANDO NOTA ACIMA DE 7 
if (media>= 7 ){
    Console.WriteLine ($"{aluno} voce esta aprovado com a  media {media}");
} else{
    (media>= 7 )
    Console.WriteLine ($"{aluno} voce esta REPROVADO com a  media {media}");
}                                    
string aprovacao = (media >= 7) ? "par" : "ímpar";