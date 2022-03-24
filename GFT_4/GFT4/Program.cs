using System;
using System.Globalization;

namespace GFT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de opções: ");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. IMC");
            Console.WriteLine("3. Sair");
            Console.WriteLine("");
            Console.Write("Digite a opção desejada: ");
            int opcaoUsuario = int.Parse(Console.ReadLine());

            switch (opcaoUsuario)
            {
                case 1:
                    Console.Write("Digite número: ");
                    double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite número: ");
                    double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double soma = n1 + n2;

                    Console.WriteLine($"A soma dos números é {soma}");
                    break;

                case 2:
                    Console.Write("Digite peso: ");
                    double peso = double.Parse(Console.ReadLine());

                    Console.Write("Digite altura: ");
                    double altura = double.Parse(Console.ReadLine());

                    if(peso<18.5)
                    {
                        Console.WriteLine("Peso abaixo do normal");
                    }
                    else if(peso>=18.5 || peso<25)
                    {
                        Console.WriteLine("Peso normal");
                    }
                    else if(peso>=25 || peso <= 30)
                    {
                        Console.WriteLine("Sobre o peso");
                    }
                    else if(peso>=30 || peso <= 35)
                    {
                        Console.WriteLine("Grau de obesidade I");
                    }
                    else
                    {
                        Console.WriteLine("Consulte um médico urgentemente.");
                    }
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Digite uma opção válida.");
                    Console.Write("Digite a opção desejada: ");
                    opcaoUsuario = int.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}
