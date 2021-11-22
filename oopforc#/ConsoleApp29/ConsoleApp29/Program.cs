using System;
using System.Text;

namespace ConsoleApp29
{

    //2. Реализовать метод, который в качестве входного параметра принимает строку string,
    //    возвращает строку типа string, буквы в которой идут в обратном порядке.Протестировать метод.

    public class Program
    {
        string _input_text = "";
        public string output_text = "";
        char[] reversed_chararray;
        

   
        public string Reverse_text(string input_text)
        {
            reversed_chararray = input_text.ToCharArray();

            _input_text = input_text;



            for (int i = input_text.Length - 1; i > -1; i--)
                   {
                    reversed_chararray[_input_text.Length - i - 1] = _input_text[i]; 
                   }
            
     
            StringBuilder sb = new StringBuilder(reversed_chararray.Length);
            foreach (char ch in reversed_chararray)
            {
                sb.Append(ch);
            }
            output_text = sb.ToString();

            Console.WriteLine(output_text);
            return output_text;  
        }

        static void Main(string[] args)
        {
            Program Program1 = new Program();
            Program1.Reverse_text("собака");

            
        }
    }
}
