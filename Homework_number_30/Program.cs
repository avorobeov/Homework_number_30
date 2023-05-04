using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumber();

            Console.WriteLine($"Вы получили число: {number}");
            Console.ReadKey();
        }

        private static int GetNumber()
        {
            bool isNumber = false;
            string userInput;
            int number = 0;

            while (isNumber == false)
            {
                Console.Write("Укажите число для конвертации: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out number))
                {
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("К сожалению конвертация не удалась !");
                }
            }

            return number;
        }
    }
}
