﻿using System;

namespace task3
{
    class task3
    {
        static void Main(string[] args)
        {
            //просим пользователя ввести текст
            Console.WriteLine("Введите фразу");

            //создаем переменную для записи значения, введенного пользователем
            string text = Console.ReadLine();

            //создаем одномерный массив данных типа char c количеством элементов, равных количеству символов во фразе, введенной пользователем
            char[] symbols = new char [text.Length];

            //создаем переменную i, присваиваем ей значение, равное количеству символов во введенном тексте
            //создаем переменную j, присваиваем ей значение 0
            //посредством инкримента уменьшаем значение i до 0, увеличиваем значение j до количества, при этом присваиваем элементам массива symbols значения букв

            for (int i = text.Length - 1, j = 0; i >= 0 && j < text.Length; i--, j++)

            {
                
                symbols[j] = text[i];
                
            }
            Console.WriteLine(symbols); // построчный вывод каждого символа строки

        }
    }
}
