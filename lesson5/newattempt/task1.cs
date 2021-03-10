using System;
using System.IO;

namespace lesson5
{
    class task1
    {
        //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
        static void Main(string[] args)
        {
            
            //просим пользователя ввести текст
            Console.WriteLine("Введите все что угодно");

            //записываем введенный текст в переменную unputText
            string inputText = Console.ReadLine();

            //создаем текстовый файл с названием Textfile.txt, в котором будет записан введенный текст
            File.WriteAllText("Textfile.txt", inputText);
        }
    }
}
