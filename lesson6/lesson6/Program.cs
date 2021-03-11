using System;
using System.Diagnostics;

namespace lesson6
{
    class Program
    {



        static void Main(string[] args)
        {
            //getprocessess
            //создать методы завершения процессы, которые принимают ID или номер процесса
            //можно посмотреть taskill - чтобы посмотреть, что приложение должно уметь
            //можно сделать килами

            Console.WriteLine("Введите команду:\nl - посмотреть процессы\nk - завершить процесс\nнажмите любую другую клавишу для выхода из приложения");
            string command = Console.ReadLine();

            if (command == "l")
            {
                GetRuningProcesses();
                Console.WriteLine("Введите команду:\nl - посмотреть процессы\nk - завершить процесс\nнажмите любую другую клавишу для выхода из приложения");
                command = Console.ReadLine();
            }
            if (command == "k")
            {
                SelectProcess();
            }
            else
            {
                Environment.Exit(0);
            }

        }




        static void GetRuningProcesses()
        {
            Process[] processes = Process.GetProcesses();

            //выводим названия всех процессов через foreach
            foreach (Process instance in processes)
            {

                Console.WriteLine("Process: {0} ID: {1}", instance.ProcessName, instance.Id);

            }


        }


        static void SelectProcess()
        {
            Console.WriteLine("Выберите ID процесса, который вы хотите завершить");
            int target_ID = Convert.ToInt32(Console.ReadLine());

            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                //           foreach (ProcessModule module in process.Modules)

                if (process.Id.Equals(target_ID))
                {
                    try
                    {

                        process.Kill();
                        Console.WriteLine("Введите команду:\nl - посмотреть процессы\nk - завершить процесс\nнажмите любую другую клавишу для выхода из приложения");
                        string command = Console.ReadLine();
                    }
                    catch (InvalidOperationException)

                    {
                        Console.WriteLine("Process " + target_ID + " not found!");
                        Console.WriteLine("Введите команду:\nl - посмотреть процессы\nk - завершить процесс\nнажмите любую другую клавишу для выхода из приложения");
                        string command = Console.ReadLine();
                    }



                }

            }
        }
    }
}
