using System;

namespace GFT_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int senha;
            int senhaCorreta = 2018;

            Console.WriteLine("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

                while (senha != senhaCorreta)
                {
                
                    Console.WriteLine("Senha inválida.");
                    Console.WriteLine("Digite a senha: ");
                    senha = int.Parse(Console.ReadLine());Console.WriteLine("Acesso garantido.");
               
                }
        }
    }
}
