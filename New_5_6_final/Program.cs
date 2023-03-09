using System;
using System.Xml.Linq;

namespace New_5_6_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowPersonData();

        }
        static void ShowPersonData() //Метод показа данных пользователя
        {
            (string Name, string SurName, int Age, string HavePets, int NumOfPet, string[] PetNames, int Afavcolors, string[] favcolors) Data;
            
            Data.Name = "1"; //Предварительные присваивания начальных значений для корректной работы
            Data.SurName = "1";
            Data.Age = 1;
            Data.HavePets = "1";
            Data.NumOfPet = 1;
            Data.PetNames = new string[4];
            Data.Afavcolors = 1;
            Data.favcolors = new string[4];                       

            (Data.Name, Data.SurName, Data.Age, Data.HavePets, Data.NumOfPet, Data.PetNames, Data.Afavcolors, Data.favcolors) = PersonData();            
            if (Data.HavePets == "Да") {
                Console.WriteLine("\nВаше имя: {0}.\nВаша фамилия: {1}.\nВаш возраст: {2}.\nУ вас {3} питомца/питомцев: .", Data.Name, Data.SurName, Data.Age, Data.NumOfPet);
                foreach (var pets in Data.PetNames)
                {
                    Console.WriteLine(pets);
                }
                                
            }
            else {
                Console.WriteLine("\nВаше имя: {0}.\nВаша фамилия: {1}.\nВаш возраст: {2}.", Data.Name, Data.SurName, Data.Age, Data.NumOfPet);
            }
            Console.WriteLine("Ваши любимые цвета: ");
            ShowColor(Data.favcolors);
            Console.ReadKey();
        }
        static (string Name, string SurName, int Age, string HavePets, int NumOfPet, string[] PetNames, int Afavcolors, string[] favcolors) PersonData () //Метод для ввода данных пользователя
        {
            (string Name, string SurName, int Age, string HavePets, int NumOfPet, string[] PetNames, int Afavcolors, string [] favcolors) Data;
            Console.Write("Введите ваше имя: ");
            Data.Name = Console.ReadLine();
            Console.Write("\nВведите вашу фамилию: ");
            Data.SurName = Console.ReadLine();
            Data.Age = 0;
            Console.Write("\nВведите ваш возраст: ");            
            Data.Age = CorrectNumber(ref Data.Age);
            Console.Write("\nУ вас есть питомцы? (Да/Нет): ");            
            Data.HavePets = Console.ReadLine();
            Data.NumOfPet = 0;
            Data.PetNames = new string[4]; // Без предварительного присваивания выскакивает ошибка
            if (Data.HavePets == "Да" || Data.HavePets == "да")
            {
                Console.Write("\nВведите количество питомцев: ");                
                Data.NumOfPet = CorrectNumber(ref Data.NumOfPet);               
                Data.PetNames = NamePet(Data.NumOfPet);               

            }            
            Data.Afavcolors = 0;
            Console.Write("\nВведите количество любимых цветов:");
            Data.Afavcolors = CorrectNumber(ref Data.Afavcolors);

            Data.favcolors = new string[Data.Afavcolors];
            AColors(Data.Afavcolors, Data.favcolors);                       
            return Data; 
            
        }
        static int CorrectNumber(ref int number) // Метод проверяет корректность введенных чисел
        {
            bool result = int.TryParse(Console.ReadLine(), out number);
            if (result != true || number == 0)
            {
                Console.WriteLine("Введите корректное число больше 0: ");
                CorrectNumber(ref number);
            }            
            return number;


        }
        static string[] NamePet(int number) //Метод для ввода в массив кличек животных
        {
            Console.WriteLine("Введите клички питомцев. ");
            string[] PetNames = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Введите кличку питомца номер {0}: ", i + 1);
                PetNames[i] = Console.ReadLine();

            }
            return PetNames;
             

        } 
        static string[] AColors(int Afavcolors, string[] favcolors) //Метод ввода цветов
        {
            Console.WriteLine("Выберите {0} цвета/цветов из представленных: красный, желтый, зеленый, голубой, фиолетовый, циан, белый и введите введите их.", Afavcolors);
            for (int i = 0; i < Afavcolors; i++)
            {
                Console.Write("Введите ваш цвет номер {0}: ", i + 1);
                favcolors[i] = Console.ReadLine();
            }
            return favcolors;
        }
        static void ShowColor(string[] favcolors) //Метод показа выбранных цветов
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