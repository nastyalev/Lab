using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char s;
            double c = 0.0;

            Console.WriteLine("Приложение калькулятор.");
            Console.WriteLine("Ввод дробных чисел в виде 0,0");
            Console.WriteLine();
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию: (+ - * /) ");
            s = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            switch (s)
            {
                case '+':
                    c = a + b;
                    Console.WriteLine("Результат = " + c);
                    break;
                case '-':
                    c = a - b;
                    Console.WriteLine("Результат = " + c);
                    break;
                case '/':
                    c = a / b;
                    Console.WriteLine("Результат = " + c);
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine("Результат = " + c);
                    break;
                default:
                    Console.WriteLine("Неверный оператор!");
                    break;
            }
        }
    }
}
