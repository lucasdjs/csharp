using System;


namespace Exercicio_1_Retangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
       

        public double TotalArea() {

            return Largura * Altura;
        }
        public double Perimetro()
        {

            return (Largura + Altura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
            
            
        }
    }
}
