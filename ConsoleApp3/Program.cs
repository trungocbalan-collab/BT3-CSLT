using System;
using System.Text;

namespace BaitapCSLT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            BT1();
            BT2();
            BT3();
            BT4();
            BT5();

            Console.ReadKey();
        }

        static void BT1()
        {
            int x, y;
            char operation;
            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");
        }

        static void BT2()
        {
            int n;
            Console.Write("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("{0} is an even number.", n);
            else
                Console.WriteLine("{0} is an odd number.", n);
        }

    }
}