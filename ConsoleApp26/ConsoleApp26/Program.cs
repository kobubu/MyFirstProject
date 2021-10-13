using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1000, 2000, ac_type.debit_account);
            { 
            }

            account1.Output_data();
        }
    }
}
