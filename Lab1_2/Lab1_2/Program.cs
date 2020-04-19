using System;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод только четных символов
            Console.WriteLine("Введите цифры");
            string str = Console.ReadLine();
            string[] s = str.Split(' ');
            for (int i = 0; i < s.Length; i++)
                if (int.Parse(s[i]) % 2 == 0)
                    Console.Write("{0} ", s[i]);

        }
    }
}
