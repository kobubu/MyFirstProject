using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {

        public static void Main()
        {
            //прописываем корневой каталог
            ShowDirectoryAndFiles(rootPath);
            SelectControls();

        }

       static string rootPath = @"C:\";
        public static void ShowDirectoryAndFiles(string showPath)
        {
            //прописываем путь к корневому каталогу
            showPath = rootPath;

            //строковы массив с названиями папок по пути к корневому каталогу
            string[] dirs = Directory.GetDirectories(rootPath);
            //если нужен код для указания всех подпапок: string[] dirs = Directory.GetDirectories(rootPath, "*",SearchOption.AllDirectories);

            //получаем название файлов из корневой папки
            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            //выводим названия всех файлов

            //выводим названия папок
            foreach (string dir in dirs)
            {
                //вывод названия папки
                Console.WriteLine(dir);
            }

            foreach (string file in files)
            {
                // указываем название файла без пути к нему
                Console.WriteLine(Path.GetFileName(file));

                //получаем информацию о файлах
                var info = new FileInfo(file);
                //указываем информацию о файле:
                Console.WriteLine(
                    $"{Path.GetFileName(file)}: , {info.Length} bytes, {info.Attributes}, directory: {info.Directory}");
            }
        }

        #region controls

        public static void SelectControls()
        {
            //выберите файл или директорию
            Console.WriteLine("Select directory or file");
            string newPath = Console.ReadLine();

            bool directoryExists = Directory.Exists(newPath);
            bool fileExists = File.Exists(newPath);
            string command = "";

            //если папка или файл существуют, пишем показываем список команд
            if (directoryExists || fileExists)
            {

                try
                {
                    Console.WriteLine("Select command:\n" +
                                      "c - to copy file or directory\n" +
                                      "d - to delete file or directory\n" +
                                      "m - move to directory\n" +
                                      "e = to exit file or directory");
                    command = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("File or directory not found!");
                    command = Console.ReadLine();
                    
                }

                if
                    (command == "c")
                {
                    CopyDir.CopyAll();
                }

                if (command == "d")
                {
                    if (Directory.Exists(newPath))
                    {
                        Directory.Delete(newPath);
                    }
                    if (File.Exists(newPath))
                    {
                        File.Delete(newPath);
                    }

                }

                if (command == "m")
                {
                    Directory.SetCurrentDirectory(newPath);
                    rootPath = newPath;

                    Console.WriteLine("The current directory is {0}", rootPath);
                    ShowDirectoryAndFiles(rootPath);
                }

                else
                {
                    Environment.Exit(0);
                }

            }
        }
        #endregion
    }
}
