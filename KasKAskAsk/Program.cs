using System;

namespace KasKAskAsk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("T = ");
            int T = Convert.ToInt32(Console.ReadLine());
            
            int i = 0;
            int pointer = 0;

            while (i < T)
            {
                Console.WriteLine("\n");
                Console.WriteLine("N = ");
                int N = Convert.ToInt32(Console.ReadLine());
                int[] pole = new int[N];
                Random randNum = new Random();
                for (int b = 0; b < pole.Length; b++)
                {
                    pole[b] = randNum.Next(0, pole.Length);
                }
                Console.WriteLine("[{0}]", string.Join(", ", pole));
                while (pointer < pole.Length)
                {
                    if (pole[pointer] == pointer + 1 || pole[pointer] == 0)
                    {
                        pointer++;
                        if (pointer == pole.Length)
                        {
                            Console.WriteLine("Ano");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Ne");
                        break;
                    }

                }
                Array.Clear(pole, 0, N--);
                i++;
            }
            Console.ReadKey();








        }
    }
}
