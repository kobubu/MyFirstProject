using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1000, 200000, ac_type.debit_account);
            { 
            }

            Account account2 = new Account(1001, 300000, ac_type.debit_account);

            account2.Money_transfer(account1, 2000);


        }
    }
}
