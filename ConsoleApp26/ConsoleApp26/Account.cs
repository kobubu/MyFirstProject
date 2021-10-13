using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            //2.Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
            //Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.

namespace ConsoleApp26
{
    public class Account
    {

        Random rand = new Random();
        public List<int> randomList = new List<int>();
        public static int _ac_number;
        private double _balance;
        private ac_type _ac_type;


        public void create_acc_number()
        {
            _ac_number = rand.Next(1, 1000000);
            while (randomList.Contains(_ac_number))
                _ac_number++;
        }

        public void input_data(double balance, ac_type type)
        {
            
            _balance = balance;
            _ac_type = type;

        }

        public void Output_data()
        {

            
            Console.WriteLine($"account number = {_ac_number} balance = {_balance} account type = {_ac_type}");

        }

        public int account_increment()
        {

            _ac_number++;
            return _ac_number;

        }


    }
}
