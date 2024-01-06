using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumberInArray
{
    internal class Program
    {
        static List<int> primeArray(int[] arr)
        {
            List<int> list = new List<int>();
                  
            for(int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }

            bool isPrime(int num)
            {
                if(num <= 1)
                {
                    return false;
                }
                for(int i = 2;  i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return list;
        }

        static int[] enterArray()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 number:");
            for(int i = 0; i < 10; i++)
            {
                arr[i] = checkInput(i);
            }
            
            return arr;

        }

        static int checkInput(int i)
        {
            while(true) { 
                try
                {
                    Console.Write("Number " + (i + 1) + ": ");
                    int n = int.Parse(Console.ReadLine());
                    return n;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid Number! Please re-input!");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = enterArray();
            List<int> list = primeArray(arr);
            Console.Write("Prime numbers are: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();           
        }
    }
}
