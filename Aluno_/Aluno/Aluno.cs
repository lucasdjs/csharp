using System;
using System.Globalization;


namespace Aluno_
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public double soma()
        {
            return Nota1 + Nota2 + Nota3;

        }
        public override string ToString()
        {
            if (soma() >= 60.00)
            {
                return  "NOTA FINAL = " + soma().ToString("F2", CultureInfo.InvariantCulture) +"\n"+
                "APROVADO"; 
                
            }
            else
            {
                double falta = 60.00 - soma();
                return
                "NOTA FINAL = " + soma().ToString("F2", CultureInfo.InvariantCulture) +"\n" +
               "REPROVADO" + "\n"+
                 "FALTARAM = " + falta.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";

            }
        }

    }
}
