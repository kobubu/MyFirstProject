using System;

namespace lesson4
{
    class task1
    {


        //Написать метод GetFullName(string firstName, string lastName, string patronymic), 
        //принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
        // Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

        static void Main(string[] args)
        {
            string name1 = GetName();
            string name2 = GetName();
            string name3 = GetName();

            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);


        }



        static string GetName()
        {
            Console.WriteLine("Введите имя");
            string userName = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string userSurname = Console.ReadLine();

            Console.WriteLine("Введите отчество");
            string patronymic = Console.ReadLine();

            string fullName = $"{userName} " + $"{userSurname} " + $"{patronymic}";

            return fullName;

                
            
        }



    }
}
