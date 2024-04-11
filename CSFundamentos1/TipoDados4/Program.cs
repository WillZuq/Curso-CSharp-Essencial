Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string"; //tipo de dado imutável. Ao declarar novos valores, aloca-se outro espaço na memória
valor = "Isto é uma string alterada";
valor = "teste";

Console.WriteLine(valor);
//StringBuilder

dynamic nota = 10;
dynamic valor2 = 8.55m;
dynamic nome2 =  "Maria";
dynamic ativa = true;
dynamic letra1 = 'A';


Console.WriteLine(nota);
Console.WriteLine(valor2);
Console.WriteLine(nome2);
Console.WriteLine(ativa);
Console.WriteLine(letra1);

Console.ReadLine();

