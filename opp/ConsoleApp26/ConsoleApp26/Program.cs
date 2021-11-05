using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            account1.input_data(1000, 123121323, ac_type.debit_account);
            account1.Output_data();
        }
    }
}
