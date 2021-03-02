using System;

namespace task2
{
    class task2
    {


        // Написать программу — телефонный справочник — создать двумерный массив 5*2,
        // хранящий список телефонных контактов: первый элемент хранит имя контакта,
        // второй — номер телефона/e-mail.
        static void Main(string[] args)
        {


            string[,] phoneNumbers = new string[5, 2];


            Console.WriteLine("Заполни фамилии");


            for (int i = 0; i < 5; i++)
            {
                {
                    Console.WriteLine($"Укажи фамилию № " + (i+1));
                    phoneNumbers[i, 0] = Console.ReadLine();
                }
            }

            Console.WriteLine("Заполни номера телефонов");
            for (int i = 0; i < 5; i++)
            {
                {
                    Console.WriteLine($"Укажи номер телефона фамилии № " + (i+1));
                    phoneNumbers[i, 1] = Console.ReadLine();
                }
            }


            // перебор элементов массива
            for (int i = 0; i < 5; i++)
            {
                                {
                    Console.WriteLine($"{phoneNumbers[i, 0]}  {phoneNumbers[i, 1]}");
                }
                
            }
            Console.ReadLine();

        }
    }
}
