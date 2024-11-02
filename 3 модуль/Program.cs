using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System;
using System.ComponentModel.Design;

namespace _3_модуль
{
    class Program
    {


        static void Main(string[] args)
        {
            var userData = GetUserData();
            DisplayUserData(userData);
        }
        
        static (string Name, string Surname, int Age, string[] PetNames, string[] FavoriteColors) GetUserData()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();

            int age = GetValidInt("Введите возраст (целое число больше 0): ");

            Console.Write("Есть ли у вас питомец? (да/нет): ");

            bool hasPet = Console.ReadLine().Trim().ToLower() == "да";
            string[] petNames = null;

            if (hasPet)
            {
                int petCount = GetValidInt("Введите количество питомцев (целое число больше 0): ");
                petNames = GetPetNames(petCount);
            }

            int colorCount = GetValidInt("Введите количество любимых цветов (целое число больше 0): ");
            string[] favoriteColors = GetFavoriteColors(colorCount);

            return (name, surname, age, petNames, favoriteColors);
        }

        static int GetValidInt(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result) && result > 0)
                    return result;
                else
                    Console.WriteLine("Ошибка: введите целое число больше 0.");
            }
        }

     
        static string[] GetPetNames(int petCount)
        {
            string[] petNames = new string[petCount];
            for (int i = 0; i < petCount; i++)
            {
                Console.Write($"Введите кличку питомца {i + 1}: ");
                petNames[i] = Console.ReadLine();
            }
            return petNames;
        }

     
        static string[] GetFavoriteColors(int colorCount)
        {
            string[] favoriteColors = new string[colorCount];
            for (int i = 0; i < colorCount; i++)
            {
                Console.Write($"Введите любимый цвет {i + 1}: ");
                favoriteColors[i] = Console.ReadLine();
            }
            return favoriteColors;
        }

    
        static void DisplayUserData((string Name, string Surname, int Age, string[] PetNames, string[] FavoriteColors) userData)
        {
            Console.WriteLine("\n--- Данные пользователя ---");
            Console.WriteLine($"Имя: {userData.Name}");
            Console.WriteLine($"Фамилия: {userData.Surname}");
            Console.WriteLine($"Возраст: {userData.Age}");

            if (userData.PetNames != null && userData.PetNames.Length > 0)
            {
                Console.WriteLine("Питомцы:");
                foreach (var petName in userData.PetNames)
                {
                    Console.WriteLine($" - {petName}");
                }
            }
            else
            {
                Console.WriteLine("Питомцы: отсутствуют");
            }

            Console.WriteLine("Любимые цвета:");
            foreach (var color in userData.FavoriteColors)
            {
                Console.WriteLine($" - {color}");
            }
        }
    }
}