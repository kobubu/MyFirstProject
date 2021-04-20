using System;

namespace algoles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            BinarySearch(a , 3);
            
        }

        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    int c = mid + 1;
                    Console.WriteLine($"Порядковый нумер числа в списке равняется: {c}");
                    return mid;
                    
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine("Нет такой буквы на табло");
            return -1;
        }
    }
}
