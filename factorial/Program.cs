using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int result = 1;
            do
            {
                result *= number;
                number -= 1;
            } while (number != 0);
            Console.WriteLine($"Факториал равен {result}");
            Console.ReadLine();
        }   
    }
}
