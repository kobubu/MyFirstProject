using System;
using System.Configuration;

namespace ExampleApplication
{

    class Program
    {
        static void Main(string[] args)
        {

            

            Hello();
            SettingsSave();
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();


        }

        static void Hello()
        {
            string greeting = ConfigurationManager.AppSettings["greeting"];
            Console.WriteLine("{0}", greeting);
            string age = ConfigurationManager.AppSettings["age"];
            string occupation = ConfigurationManager.AppSettings["occupation"];
            Console.WriteLine("Your age is {0}, your occupation is {1}", age, occupation);
            
        }

        static void SettingsSave()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            Console.WriteLine("Введите возвраст");
            string inputAge = Console.ReadLine();
            Console.WriteLine("Введите профессию");
            string inputOccupation = Console.ReadLine();
          
            config.AppSettings.Settings["age"].Value = inputAge;
            config.AppSettings.Settings["occupation"].Value = inputOccupation;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
       

        }

       
    }





}



/* static void Main(string[] args)
{
    if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
    {

        Console.WriteLine("Введите имя пользователя:");
         Properties.Settings.Default.UserName = Console.ReadLine();
        Properties.Settings.Default.Save();
    }
        string userName = Properties.Settings.Default.UserName;
        string greeting = Properties.Settings.Default.Greeting;
    Console.WriteLine($"{greeting}, {userName}!");
}

            string age = ConfigurationManager.AppSettings["age"];
            string occupation = ConfigurationManager.AppSettings["occupation"];

            Console.WriteLine("Your age is {0}, your occupation is {1}", age, occupation);
            Console.ReadLine();
}
}

*/

