using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета
//(использовать перечислимый тип). Предусмотреть методы для доступа к данным – заполнения и чтения.
//Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

namespace ConsoleApp26
{
    public class Account
    {
        private int _ac_number;
        private double _balance;
        private ac_type _ac_type;


        public void input_data(int ac_number, double balance, ac_type type)
        {
            _ac_number = ac_number;
            _balance = balance;
            _ac_type = type;

        }

        public void Output_data()
        {

            
            Console.WriteLine($"account number = {_ac_number} balance = {_balance} account type = {_ac_type}");

        }


    }
}
