using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.1. В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой.
//У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.

namespace ConsoleApp26
{
    public class Account
    {

        private int _ac_number;
        private double _balance;
        private ac_type _ac_type;


        Random rand = new Random();
        public List<int> randomList = new List<int>();

        public int Ac_number
        {
            get
            { return _ac_number

            ;
            }
            set
            {
                _ac_number = rand.Next(1, 1000000);
                while (randomList.Contains(_ac_number))
                    _ac_number++; ;

            }
        }



        public Account(int ac_number, double balance, ac_type ac_type)
            {
            _ac_number = ac_number;
            _balance = balance;
            _ac_type = ac_type;
            Console.WriteLine($"Account {this._ac_number} was created.");
        }

        public Account(double balance)
        {
            _balance = balance;
            


        }
        public Account(ac_type ac_type)
        {
            _ac_type = ac_type;
            

        }

        public Account(double balance, ac_type ac_type)
        {
            _balance = balance;
            _ac_type = ac_type;

        }




        public void Output_data()
        {
            Console.WriteLine($"account number = {_ac_number} balance = {_balance} account type = {_ac_type}");
        }

        //4.1. В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой.
        //У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
        
        public void Money_transfer(Account Sender_account, int sum)
          {
            
            this._balance += sum;
            Sender_account._balance -= sum;
            Console.WriteLine($"Money transfer from account {Sender_account}, received amount {sum}");
            Console.WriteLine($"account number = {this._ac_number} balance = {this._balance} account type = {_ac_type}");

        }




    }
}
