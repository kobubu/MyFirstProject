using System;
using System.IO;

namespace task3
{
    class task3
    {

        //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

        static void Main(string[] args)
        {
            //введите произвольный набор чисел
            Console.WriteLine("Введите несколько чисел от 0 до 255, разделенных пробелом, пример:\n123 321 55555");
            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');
            byte[] numbers = new byte[words.Length];
            

            for (int i = 0; i < words.Length; i++)
            {
                byte tmp;
                if (byte.TryParse(words[i], out tmp))
                {
                    numbers[i] = tmp;

                }
            }

            File.WriteAllBytes("bytes.bin", numbers);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");

        }
    }
}
