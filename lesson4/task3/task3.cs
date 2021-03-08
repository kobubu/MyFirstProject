using System;

namespace task3
{

    // Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
    //  На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
    // Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
    // Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
    // Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».


    class task3
    {
        public enum Seasons

        {
            Winter,
            Spring,
            Summer,
            Autumn
        }


      private static void showSeason(Seasons mb)
        {
            switch (mb)
            {
                case Seasons.Winter:
                    Console.WriteLine("Зима");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("Весна");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("Лето");
                    break;
                case Seasons.Autumn:
                    Console.WriteLine("Осень");
                    break;
            }
        }

        static void Main(string[] args)
        
        {
        Console.WriteLine("Укажите порядковый номер месяца");
        string userNumber = Console.ReadLine();
        int choice;
        

            if (int.TryParse(userNumber, out choice) && choice >= 1 && choice <= 12)
            {
                
                if (choice >= 1 && choice <=2 || choice == 12)
                {
                    Seasons mb = Seasons.Winter;
                    showSeason(mb);
                }

                if (choice >= 3 && choice <= 5)
                {
                    Seasons mb = Seasons.Spring;
                    showSeason(mb);
                }
                
                if (choice >= 6 && choice <= 8)
                {
                    Seasons mb = Seasons.Summer;
                    showSeason(mb);
                }
                if (choice >= 9 && choice <= 11)
                {
                    Seasons mb = Seasons.Autumn;
                    showSeason(mb);
                }


                
            }

            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            
        }
    }
}
