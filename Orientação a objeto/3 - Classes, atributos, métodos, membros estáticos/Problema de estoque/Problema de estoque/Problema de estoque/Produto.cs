using System;
using System.Globalization;


namespace Problema_de_estoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            double ValorTotal = Preco * Quantidade;
            return ValorTotal;
        }

        public void AdicionarProdutos(int quantidade) {

            Quantidade = Quantidade + quantidade;

        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public void AlterarValor(double valornovo) { 
        Preco = valornovo;
        }
        public override string ToString()
        {
            return Nome + " , $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" +
                ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
