using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  Напишите метод, который отображает квадрат из некоторого символа. 
 * Метод принимает в качестве параметра: длину стороны квадрата, символ.
 */
namespace Task4
{
    class Program
    {
        static void PrintSquare(int side, char sign)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write($" {sign} ");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            Console.Write(" Введите сторону квадрата: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите произвольный символ: ");
            char sign = Convert.ToChar(Console.ReadLine());

            PrintSquare(lenght, sign);
        }
    }
}
