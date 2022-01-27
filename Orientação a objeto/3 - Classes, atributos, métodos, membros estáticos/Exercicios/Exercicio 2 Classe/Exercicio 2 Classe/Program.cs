using Exercicio_2_Classe;
using System.Globalization;

SalarioFuncionario p1 = new SalarioFuncionario();
SalarioFuncionario p2 = new SalarioFuncionario();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();

Console.Write("Salário: ");
p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário: ");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();

Console.Write("Salário: ");
p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioMedio = (p1.salario + p2.salario) / 2;
Console.WriteLine("Salário Médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

