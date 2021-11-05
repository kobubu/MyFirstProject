using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы.
//Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс,
//конструктор для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа банковского счета.
//Каждый конструктор должен вызывать метод, генерирующий номер счета.

namespace ConsoleApp26
{
    public class Account
    {

        private int _ac_number;
        private double _balance;
        private ac_type _ac_type;


        Random rand = new Random();
        public List<int> randomList = new List<int>();

        public void Create_acc_number()
        {
            _ac_number = rand.Next(1, 1000000);
            while (randomList.Contains(_ac_number))
                _ac_number++;
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
            Create_acc_number();


        }
        public Account(ac_type ac_type)
        {
            _ac_type = ac_type;
            Create_acc_number();

        }

        public Account(double balance, ac_type ac_type)
        {
            _balance = balance;
            _ac_type = ac_type;
            Create_acc_number();

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
