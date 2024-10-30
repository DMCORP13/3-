using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace _3_модуль
{
    internal class Program
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
               
                    var userData = GetUserData();
                DisplayuserData(userData);
            }
            static (string Name, string lastname, int Age, string[] petNames ,string[] FavoriteColors) getUserData()
            {
             
                    Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();

                Console.WriteLine("Введите фамилию:");
                string lastname = Console.ReadLine();
                int Age = GetValidInt("Введите возраст: ");

                Console.WriteLine("Есть ли у вас питомец ? Да или нет: ");
                bool hasPet = Console.ReadLine().Trim().ToLower() == "да";
                string[] petNames = null;
                if (hasPet)
                {
                    int peCount = GetValidInt("Введите количество питомцев: ");
                    petNames = GetValidInt[petCount];
                }
                int colorCount = GetValidInt("Введите количество лювимых цветов ");
                string[] FavoritColors = GetFavoriteColors(colorCount);

                return (name, lastname, Age, petNames, FavoritColors);
            }
            static int GetValidInt(string promt)
            {
          
                    int result;
                while (true)
                    
                        Console.Write(promt);
                if (int.TryParse(Console.ReadLine(), out result) && result > 0)
                    return result;
                else
                    Console.WriteLine("Ошибка: ");
            }
            static int GetPetNames(int petCount)
            {
                string[] petNames = new string[petCount];
                for (int i = 0; i < petCount; i++)
                {
                    Console.Write($"Введите кличку питомца{i + 1}: ");
                    petNames[i] = Console.ReadLine();
                }
                return petNames;
            }



        }
    }
}
