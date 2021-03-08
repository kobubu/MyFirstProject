using System;

namespace task2
{
    class Program
    {


        // Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
        // и возвращающую число — сумму всех чисел в строке.
        //    Ввести данные с клавиатуры и вывести результат на экран.


        // 1. Пишешь функцию со строковым аргументом и возвращаемым значением типа Int.
        // 2. Разбиваешь строку на массив с помощью оператора String.Split
        // 3. объявляешь переменную для суммы и присваиваешь 0
        // 4. в цикле проходишься по массиву из п.2 
        // 5. конвертируешь строку в число. если удачно - плюсуешь к результирующей сумме, если нет - идешь дальше по циклу.
        // 6. возвращаешь сумму

        static void Main(string[] args)
        {

            int sum1 = Sum();
            Console.WriteLine(sum1);


        }

        static int Sum()
        {
            Console.WriteLine("Введите несколько чисел, разделенных пробелом, пример:\n123 321 55555");
            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');
            int[] numbers = new int[words.Length];
            int Sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                    int tmp;
                    if (int.TryParse(words[i], out tmp))
                    {
                        numbers[i] = tmp;
                        Sum += numbers[i];
                    }

                    else
                    {
                        Console.WriteLine("Введенные значения не подходят");

                    }
            }
            return Sum;
        }
    }
}   
