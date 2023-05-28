// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Въведете Температура в C°=");
double TC = double.Parse(Console.ReadLine());
double TF = TC *4.5 +32;
Console.WriteLine($"Температурата във F° е = {TF}");