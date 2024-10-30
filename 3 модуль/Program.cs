using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace _3_модуль
{
    internal class Program
    {
        class MainClass
        {
            public static void Main(string[] args)
            {

                (string name,string lastname, int age, bool haspet) anketa;
                Console.Write("Введите имя: ");
                anketa.name = Console.ReadLine();
                Console.Write("Введите возраст цифрами: ");
                anketa.age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Есть ли у вас питомец? Да или нет");
                var haspets = true;

                if (haspats==true)
                {
                   

                }
                else 
                {
                   
                }


                Console.WriteLine("Ваше имя: {0}", anketa.name);
                Console.WriteLine("Ваш возраст: {0}", anketa.age);
                Console.WriteLine("Есть ли у вас питомец?: {0}", anketa.haspet); 

                Console.ReadKey();
                
            }
        }
    }
}