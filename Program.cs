
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;

            Console.Write("Введите первое число: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                    break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Ошибка: деление на ноль");
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: недопустимая операция");
                    break;
            }

            Console.ReadLine();
        }
    }
}
