using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = Console.ReadLine().Split(' ');

            int M = int.Parse(vect[0]);
            int N = int.Parse(vect[1]);

            int[,] Matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vect2 = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    Matriz[i, j] = int.Parse(vect2[j]);
                }
            }

            Console.Write("Digite um Numero Pertencente a Matriz: ");
            int Valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Matriz[i, j] == Valor)
                    {
                        Console.WriteLine($"Posicion {i},{j}:");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + Matriz[i, (j - 1)]);
                        }
                        if (i >= 0)
                        {
                            Console.WriteLine("Right: " + Matriz[i, (j + 1)]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Up: " + Matriz[(i + 1), j]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Down: " + Matriz[(i - 1), j]);
                        }
                    }
                }
            }
        }
    }
}
