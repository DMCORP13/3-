using System.Reflection.Metadata;
using System.Xml.Linq;

namespace _3_модуль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("ваш возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Твое имя {0} возраст {1} ", name, age);
            Console.WriteLine("Ваша дата рождения: ");
            var birhdate = Console.ReadLine();
        }
    }
}
