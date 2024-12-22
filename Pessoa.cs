using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExercicioIMC
{
    internal class Pessoa
    {
        public double peso, altura;

        public double RetornarIMC()
        {
            return peso / (altura * altura); ;
        }

        public string Resultado(double imc)
        {
            string mensagem;

            if (imc < 18.5)
            {
                mensagem = "Abaixo do peso!";
            }
            else if (imc < 25)
            {
                mensagem = "Peso normal!";
            }
            else if (imc < 30)
            {
                mensagem = "Acima do peso!";
            }
            else if (imc < 35)
            {
                mensagem = "Obesidade I!";
            }
            else if (imc < 40)
            {
                mensagem = "Obesidade II!";
            }
            else
            {
                mensagem = "Obesidade III!";
            }

            return mensagem;
        }

        public void Mensagem()
        {
            string resultadoFinal = Resultado(RetornarIMC());
            double calculoIMC = RetornarIMC();

            Console.WriteLine($"O seu imc e igual a: {calculoIMC}\nSeu resultado e: {resultadoFinal}");
        }
    }
}
