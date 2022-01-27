using System;
using System.Globalization;
using Aluno_;


Aluno dados = new Aluno();

Console.Write("Nome do aluno: ");
dados.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
dados.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
dados.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
dados.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(dados);

