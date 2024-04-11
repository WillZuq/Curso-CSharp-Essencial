Console.WriteLine("### Struct DateTime ##\n");

DateTime hoje = DateTime.Now;

Console.WriteLine(hoje);

// criar uma data específica usa formato: aaaa, mm, dd
DateTime dataHoje = new DateTime(2024, 04, 11);
Console.WriteLine(dataHoje);

// criar uma data com hora específica usa formato: aaaa, mm, dd, hh, mm, ss
DateTime dataHoraHoje = new DateTime(2024, 04, 11, 16, 44, 15);
Console.WriteLine(dataHoraHoje);

//Extrair informações da Data atual
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

//Adicionando valores
Console.WriteLine(hoje.AddYears(1));
Console.WriteLine(hoje.AddMonths(3));
Console.WriteLine(hoje.AddDays(25));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddMinutes(15));

//Obtendo o dia da semana e dia do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//Data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

//Hora no formato longo e curto
Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();