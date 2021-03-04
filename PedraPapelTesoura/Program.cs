using System;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Pedra, Papel Tesoura");
            Console.WriteLine("Escolha: ");
            Console.WriteLine(" [ 1 ] Pedra");
            Console.WriteLine(" [ 2 ] Papel");
            Console.WriteLine(" [ 3 ] Tesoura");
            int caso = int.Parse(Console.ReadLine());
                     /*
                     * 0 - Pedra
                     * 1 - Papel
                     * 2 - Tesoura
                     */
            switch (caso)
            {
                case 1:

                    Random r = new Random();
                    int pc = r.Next(0, 2);

                    if (pc == 0)
                    {
                        Console.WriteLine("Empate! O Computador escolheu Pedra também!");
                        
                        Console.ReadKey();
                        break;
                    }
                    else if (pc == 1)
                    {
                        Console.WriteLine("Você perdeu! O Computador escolheu Papel");
                        Console.ReadKey();
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Você Venceu! O Computador escolheu Tesoura");
                        Console.ReadKey();
                        break;
                    }

                case 2:

                    Random r1 = new Random();
                    int pc1 = r1.Next(0, 2);

                    if (pc1 == 0)
                    {
                        Console.WriteLine("Você Venceu! O Computador escolheu Pedra");
                        Console.ReadKey();
                        break;
                    }
                    else if (pc1 == 1)
                    {
                        Console.WriteLine("Empate! O Computador também escolheu Papel");
                        Console.ReadKey();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Você Perdeu! O Computador escolheu Tesoura");
                        Console.ReadKey();
                        break;
                    }

                case 3:

                    Random r2 = new Random();
                    int pc2 = r2.Next(0, 2);

                    if (pc2 == 0)
                    {
                        Console.WriteLine("Você perdeu! O Computador escolheu Pedra");
                        Console.ReadKey();
                        break;
                    }
                    else if (pc2 == 1)
                    {
                        Console.WriteLine("Você Venceu! O Computador escolheu Papel");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Empate! O Computador também escolheu Tesoura");
                        Console.ReadKey();
                        break;
                    }

                default:
                    Console.WriteLine("Comando Inválido!");
                    break;
            }
        }
    }
}
