using Problema_de_estoque;
using System.Globalization;

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto: ");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço do produto: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque do produto: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();

Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");

int qte = int.Parse(Console.ReadLine());

p.AdicionarProdutos(qte);

Console.WriteLine();

Console.WriteLine("Dados Atualizados: "+ p);

Console.WriteLine();
Console.Write("Digite o numero de produtos a ser removido no estoque: ");

int qteremovido = int.Parse(Console.ReadLine());

p.RemoverProduto(qteremovido);

Console.WriteLine();

Console.WriteLine("Dados Atualizados: " + p);
Console.WriteLine();

Console.Write("Alterar valor para: ");

double alterar = double.Parse(Console.ReadLine());

p.AlterarValor(alterar);

Console.WriteLine();

Console.WriteLine("Dados Atualizados: " + p);


