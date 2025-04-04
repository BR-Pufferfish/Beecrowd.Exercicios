//Exercício 1008 Beecrowd
using System.Globalization;

string A = (Console.ReadLine());
int B = int.Parse(Console.ReadLine());
double C = double.Parse(Console.ReadLine());
double D = (B*C);
string X = D.ToString("F2", CultureInfo.InvariantCulture);
Console.WriteLine("NUMBER = " + A);
Console.WriteLine("SALARY = U$ " + X);