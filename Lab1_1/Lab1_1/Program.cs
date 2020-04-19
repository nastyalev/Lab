using System;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сложение всех чётных чисел в массиве 
            int s = 0;
            int[] x = new int[10];
            x[0] = 1;
            x[1] = 2;
            x[2] = 3;
            x[3] = 4;
            x[4] = 5;
            x[5] = 6;
            x[6] = 7;
            x[7] = 8;
            x[8] = 9;
            x[9] = 10;

            for (int i = 0; i < 10; i++)
            {
                if (x[i] % 2 == 0)
                {
                    s = s + x[i];
                }
            }
            Console.WriteLine(s);
        }
    }
}
