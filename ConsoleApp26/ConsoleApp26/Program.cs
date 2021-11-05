using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            account1.create_acc_number();
            account1.input_data(123121323, ac_type.debit_account);
            account1.Output_data();
        }
    }
}
