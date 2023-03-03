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

            PersonData(); //(Name,  SurName,  Age,  HavePets,  NumOfPet, PetNames [],  Afavcolors);
        }
        static void PersonData () //string Name, string SurName, int Age, bool HavePets, int NumOfPet,  string [] PetNames, int Afavcolors)
        {
            Console.Write("Введите ваше имя: ");
            string Name = Console.ReadLine();
            Console.Write("\nВведите вашу фамилию: ");
            string SurName = Console.ReadLine();
            Console.Write("\nВведите ваш возраст: ");
            int Age = 0;
            Age = CorrectNumber(Age);
            Console.Write("\nУ вас есть питомцы? (Да/Нет)");
            string Pets = Console.ReadLine();
            int NumOfPet = 0;
            if (Pets == "Да")
            {
                Console.WriteLine("Введите количество питомцев: ");
                NumOfPet =  CorrectNumber(NumOfPet);
                NamePet(NumOfPet);
            }
            int Afavcolors = 0;
            Console.WriteLine("Введите количество любимых цветов:");
            Afavcolors = CorrectNumber(Afavcolors);

            

        }
        static int CorrectNumber (int number) {
            bool result = int.TryParse(Console.ReadLine(), out number);
            if (result != true || number == 0)
                {
                    Console.WriteLine("Введите корректное число больше 0: ");
                    CorrectNumber(number);
                }
                return number;
            
            
        }
        static string [] NamePet (int number)
        {
            Console.WriteLine("Введите клички питомцев: ");
            string[] PetNames = new string [number];
            for (int i = 0; i < number; i++) {
                Console.Write("Введите кличку животного номер {0}: ", i + 1);
                PetNames[i] = Console.ReadLine();
                
            }
            return PetNames;

        }
        
    }
}