using Exercicio_1_Retangulo;
using System.Globalization;

 Retangulo Ret = new Retangulo();

Console.WriteLine("Entre a largura e altura do retângulo: ");
Ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Ret.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + Ret.TotalArea().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + Ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + Ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));





