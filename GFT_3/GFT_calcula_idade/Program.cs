using System;

namespace GFT_calcula_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            double peso;

            for(int i=1; i<=2; i++)
            {
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.Write("Digite o peso: ");
                peso = double.Parse(Console.ReadLine());

                if (idade <= 10)
                {

                }

            }

         Console.WriteLine($"Média peso faixa etária 1 a 10 anos: ");

            Console.ReadKey();
        }
    }
}
