using System;

namespace _221003_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Written = Convert.ToInt32(Console.ReadLine());
            int Reading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Value(Written, Reading)); 


        }
        public static int Value (int Written, int Reading)
        {
            int count = 0;
            int swap = Written;
            while (swap > 1)
            {
                swap /= 10;
                count++;
                {
                    for (int i = 0; i < count; i++)
                    {
                        
                    }
                }                
            }
            return Written;
        }
    }
}
