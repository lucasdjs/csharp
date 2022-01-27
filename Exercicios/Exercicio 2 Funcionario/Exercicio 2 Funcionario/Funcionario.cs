using System;
using System.Globalization;


namespace Exercicio_2_Funcionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido;

        public double Salario()
        {
            SalarioLiquido = SalarioBruto - Imposto;
            return SalarioLiquido;
        }
        public void AumentarSalario(double porcentagem)
        {
            double calculo = porcentagem / 100;
            SalarioBruto = (SalarioBruto * calculo) + SalarioBruto;
            SalarioBruto = SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return  Nome + ", $" ;
        }
    }
}
