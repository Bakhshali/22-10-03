using System;

namespace _221003_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 69, 45, 67, 39, 0 };
            Biggest (array);
            
        }
        public static void Biggest (int[]array)
        {   
            int big=array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > big)
                {
                    big = array[i];
                    
                }
                {

                }
                
            }
            Console.WriteLine("Biggest number is - " + big);
        }           
        }
    }
