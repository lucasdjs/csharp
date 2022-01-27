using Exercicio_2_Funcionario;
using System.Globalization;

Funcionario funcionario = new Funcionario();

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();

Console.Write("Salário Bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;


Console.WriteLine("Funcionário: " + funcionario + funcionario.Salario().ToString("F2", CultureInfo.InvariantCulture));

Console.Write("Digite a porcentagem para aumentar o salário: ");
double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
funcionario.AumentarSalario(p);

Console.WriteLine("Dados Atualizados: " + funcionario + funcionario.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));




