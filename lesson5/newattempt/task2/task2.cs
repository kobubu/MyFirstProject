using System;
using System.IO;

namespace task2
{
    class task2
    {
        static void Main(string[] args)
        {
            //создаем переменную, которой присваиваем значение текущего времени
            DateTime date1 = new DateTime();
            
            //присваиваем ей значение текущей даты и времени 
            date1 = DateTime.Now;

            //записываем значение времени в переменную
            string inputText = $"{date1.ToLongTimeString()}";

            //ззаписываем в файл startup.txt
            File.AppendAllText("startup.txt", inputText);

        }
    }
}
