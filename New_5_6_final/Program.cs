using System;

namespace New_5_6_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string Name = "0", SurName = "0";
            int Age = 0, NumOfPet = 0, Afavcolors = 0;
            bool HavePets = true;
            string[] PetNames = {"0", "0"};*/

            //(Name,  SurName,  Age,  HavePets,  NumOfPet, PetNames [],  Afavcolors);
            PersonData();


        }
        static void ShowPersonData(string Name, string SurName, int Age, bool HavePets, int NumOfPet, string[] PetNames, int Afavcolors)
        {


        }
        static void PersonData() //string Name, string SurName, int Age, bool HavePets, int NumOfPet,  string [] PetNames, int Afavcolors)
        {
            Console.Write("Введите ваше имя: ");
            string Name = Console.ReadLine();
            Console.Write("\nВведите вашу фамилию: ");
            string SurName = Console.ReadLine();
            Console.Write("\nВведите ваш возраст: ");
            int Age = 0;
            Age = CorrectNumber(Age);
            Console.Write("\nУ вас есть питомцы? (Да/Нет)");
            string HavePets = Console.ReadLine();
            int NumOfPet = 0;
            if (HavePets == "Да")
            {
                Console.WriteLine("Введите количество питомцев: ");
                NumOfPet = CorrectNumber(NumOfPet);
                string [] PetNames = NamePet(NumOfPet);

            }
            int Afavcolors = 0;
            Console.WriteLine("Введите количество любимых цветов:");
            Afavcolors = CorrectNumber(Afavcolors);

            string[] favcolors = new string[Afavcolors];
            AColors(Afavcolors, favcolors);
            ShowColor(favcolors);

        }
        static int CorrectNumber(int number)
        {
            bool result = int.TryParse(Console.ReadLine(), out number);
            if (result != true || number == 0)
            {
                Console.WriteLine("Введите корректное число больше 0: ");
                CorrectNumber(number);
            }
            return number;


        }
        static string[] NamePet(int number)
        {
            Console.WriteLine("Введите клички питомцев: ");
            string[] PetNames = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Введите кличку животного номер {0}: ", i + 1);
                PetNames[i] = Console.ReadLine();

            }
            return PetNames;

        }
        static string[] AColors(int Afavcolors, string[] favcolors)
        {
            Console.WriteLine("Введите выберите {0} цвета/цветов из (красный, желтый, зеленый, голубой, фиолетовый, циан, белый) и введите ваши любимые цвета:", Afavcolors);
            for (int i = 0; i < Afavcolors; i++)
            {
                Console.Write("Введите ваш цвет номер {0}: ", i + 1);
                favcolors[i] = Console.ReadLine();
            }
            return favcolors;
        }
        static void ShowColor(string[] favcolors)
        {
            for (int i = 0; i < favcolors.Length; i++)
            {
                switch (favcolors[i])
                {
                    case "красный":
                        Console.BackgroundColor = ConsoleColor.Red; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                        Console.WriteLine("Ваш {0}-й цвет {1}.", i + 1, favcolors[i]);
                        break;


                    case "желтый":
                        Console.BackgroundColor = ConsoleColor.Yellow; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                        Console.WriteLine("Ваш {0}-й цвет {1}.", i + 1, favcolors[i]);
                        break;

                    case "зеленый":
                        Console.BackgroundColor = ConsoleColor.Green; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                        Console.WriteLine("Ваш {0}-й цвет {1}.", i + 1, favcolors[i]);
                        break;

                    case "голубой":
                        Console.BackgroundColor = ConsoleColor.Blue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                        Console.WriteLine("Ваш {0}-й цвет {1}", i + 1, favcolors[i]);
                        break;

                    case "синий":
                        Console.BackgroundColor = ConsoleColor.DarkBlue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                        Console.WriteLine("Ваш {0}-й цвет {1}", i + 1, favcolors[i]);
                        break;

                    case "фиолетовый":
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                        Console.WriteLine("Ваш {0}-й цвет {1}", i + 1, favcolors[i]);
                        break;

                    case "циан":
                        Console.BackgroundColor = ConsoleColor.Cyan; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                        Console.WriteLine("Ваш {0}-й цвет {1}", i + 1, favcolors[i]);
                        break;

                    case "белый":
                        Console.BackgroundColor = ConsoleColor.White; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                        Console.WriteLine("Ваш {0}-й цвет {1}", i + 1, favcolors[i]);
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Цвет {0} не найден в базе", favcolors[i]);
                        break;
                }
            }
        }
    }
}