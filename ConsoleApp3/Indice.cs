using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Indice
    {
        double Altura { get; set; }
        double Peso { get; set; }

        public Indice(double peso, double altura)
        {
            Altura = altura;
            Peso = peso;
        }

        public double Imc(double peso, double altura)
        {
            double imc;
            imc = Peso / (Altura * Altura);
            if (imc < 18.5)
            {
                Console.WriteLine("Muito magro!");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso ideal!");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Obesidade!");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau 2!");
            }
            else
            {
                Console.WriteLine("Obesidade mórbida!");
            }

            return imc;
        }

        public void Zerar(double valor1, double valor2)
        {
            Peso = valor1 - valor1;
            Altura = valor2 - valor2;
        }
        public override string ToString()
        {
            return "Seu peso é: " +
                Peso +
                " Sua altura é: " +
                Altura;                
        }
    }
}
