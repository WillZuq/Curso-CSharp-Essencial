using System.Runtime.CompilerServices;

Console.WriteLine("### Nullable Types ###\n ");

// int i = null; Essa declaração é impossível pois tipos de valor (int, float, bool, char) não podem ter null como valor atribuído

Nullable<int> i = null;
Nullable<bool> b = null;
Nullable<double> d = null;

int? i1 = null;
bool? b1 = null;
double? d1 = null;

Console.WriteLine(i);
Console.WriteLine(b);
Console.WriteLine(d);

Console.WriteLine(i1);
Console.WriteLine(b1);
Console.WriteLine(d1);

int? x = null;
// int y = x; Isso implicaria em um erro. Tipo de valor não pode receber null
int y = x ?? 0; // Se X# null então X, senão X = 0;
Console.WriteLine(x);
Console.WriteLine(y);

int? z = null;

if (z.HasValue) {

    Console.WriteLine($"Z = {z.Value}");
} 
else {
    Console.WriteLine("Z não possui um valor");
}

Console.ReadKey();