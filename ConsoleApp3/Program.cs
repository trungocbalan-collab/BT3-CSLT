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
            Console.WriteLine("Bang gia tri cua ham so x = y^2 + 2y + 1");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("{0,10} | {1,10}", "y", "x");
            Console.WriteLine("---------------------------------------");
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;

                Console.WriteLine("{0,10} | {1,10}", y, x);
            }
        }

        static void BT3()
        {
            float distance;
            float hour, min, sec;
            float timeSec;
            float mps, kph, mph;

            Console.Write("Nhap quang duong (met): ");
            distance = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap thoi gian - Gio: ");
            hour = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap thoi gian - Phut: ");
            min = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap thoi gian - Giay: ");
            sec = Convert.ToSingle(Console.ReadLine());
            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;
            Console.WriteLine("Ket qua:");
            Console.WriteLine("Toc do (m/s) la: {0}", mps);
            Console.WriteLine("Toc do (km/h) la: {0}", kph);
            Console.WriteLine("Toc do (mph) la: {0}", mph);
        }

        static void BT4()
        {
            float r;
            float pi = 3.1415926535f;
            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Surface area of the sphere: " + 4 * pi * (r * r));
            Console.WriteLine("Volume of the sphere: " + 4f / 3f * pi * (r * r * r));
        }

        static void BT5()
        {
            char symbol;
            Console.Write("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());
            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("It's a lowercase vowel.");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("It's a digit.");
            }
            else
            {
                Console.Write("It's another symbol.");
            }
        }
    }
}
