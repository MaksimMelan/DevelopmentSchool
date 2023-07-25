using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOutput
{
    internal class NameOutput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя плиз: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;

            string middleLine = $"{symbol}{name}{symbol}";
            string frame = string.Empty;

            for (int i = 0; i < middleLine.Length; i++)
            {
                frame += symbol;
            }

            Console.WriteLine("\n\n");
            Console.WriteLine(frame);
            Console.WriteLine(middleLine);
            Console.WriteLine(frame);
        }
    }
}
