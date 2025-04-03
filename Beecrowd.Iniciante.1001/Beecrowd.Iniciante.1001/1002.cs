//Exercício 1002 Beecrowd
using System.Globalization;

double raio, pi, area;
raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
pi = 3.14159;
area = ((raio * raio) * pi);
Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));