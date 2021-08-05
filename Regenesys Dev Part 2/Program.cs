using System;

namespace Regenesys_Dev_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] list = { 10.61, 7.92, 6.98, 9.14, 3.13 };
            double[] tempList = list;
            Console.Write("Original Array: ");
            foreach (double i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // reverse the array
            Array.Reverse(tempList);
            Console.Write("Reversed Array: ");
            foreach (double i in tempList)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
