using System.Reflection.Metadata;
using System.Xml.Linq;

namespace _3_модуль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любивый цвет на английском языке с малеькой буквы");
            for (int i = 5; i > 1; i--)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }
            

            




        }
    }
}