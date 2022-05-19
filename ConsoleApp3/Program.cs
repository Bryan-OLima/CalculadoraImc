using System;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja fazer uma consulta? [S/N]: ");
            string resposta = Console.ReadLine().ToLower();

            while (resposta == "s")
            {
                Console.Write("peso: ");
                double peso = double.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine());

                Indice pessoa = new Indice(peso, altura);

                Console.WriteLine("Seu imc é: " + pessoa.Imc(peso, altura).ToString("F2"));
                pessoa.Zerar(peso, altura);
                
                Console.WriteLine();
                Console.Write("Deseja fazer uma nova consulta? [S/N]: ");
                resposta = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Obrigado por usar nosso sistema de IMC!");
        }


    }
}
