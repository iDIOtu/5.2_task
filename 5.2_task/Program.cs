using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string inputStr = Console.ReadLine();

            int startIndex = 0;
            if (inputStr.Length > 0 && inputStr[0] == '-')
            {
                startIndex = 1;
            }

            int sum = 0;
            for (int i = startIndex; i < inputStr.Length; i++)
            {
                if (!char.IsDigit(inputStr[i]))
                {
                    Console.WriteLine("Это не число");
                    break;
                }
                
                //'1' - '0' = 49 - 48
                sum += inputStr[i] - '0';

                if (i + 1 == inputStr.Length)
                    Console.WriteLine($"Сумма: {sum}");
            }
        }
    }
}