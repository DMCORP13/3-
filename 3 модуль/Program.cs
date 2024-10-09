using System.Xml.Linq;

namespace _3_модуль
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string моеимя = "Артур";
            byte мойвозраст = 32;
            bool питомец = true;
            double размеробуви = 41.5;

            Console.WriteLine("мое имя " + моеимя);
            Console.WriteLine("мне " + мойвозраст);
            Console.WriteLine("У тебя есть питомец? " + питомец);
            Console.WriteLine("мой размер обуви " + размеробуви);
            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);
            Console.WriteLine("byte {0} ", byte.MinValue);
            Console.WriteLine("byte {0} ", byte.MaxValue);


            Console.ReadKey();


        }
    }
}
