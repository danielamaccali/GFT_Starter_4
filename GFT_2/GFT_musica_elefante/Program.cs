using System;

namespace GFT_musica_elefante
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUsuario;

            Console.Write("Digite um valor: ");
            valorUsuario = int.Parse(Console.ReadLine());

            switch (valorUsuario)
            {
                case 1:
                    Console.WriteLine("Um elefante incomoda muito a gente...");
                    break;
                case 2:
                    Console.WriteLine("Dois elefantes incomodam muito mais...");
                    break;
                case 3:
                    Console.WriteLine("Três elefantes Incomoda Incomoda Incomoda muito mais...");
                    break;


            }
        }
    }
}
