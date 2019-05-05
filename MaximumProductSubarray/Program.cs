using System;

namespace MaximumProductSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Product Subarray!");
            Console.WriteLine("-------------------------");

            try
            {
                int numberElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements of the array separated by" +
                    " space, comma or semi-colon");
                int[] array = new int[numberElements];
                String[] elements = Console.ReadLine().Split(' ', ',');
                for (int index = 0; index < numberElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
                PrintMaxProductSubArray(array);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static void PrintMaxProductSubArray(int[] array) {
            int maxProductEndingHere = array[0];
            int maxProductSoFar = array[0];

            for (int index = 1; index < array.Length; index++) {
                maxProductEndingHere *= array[index];

                if (maxProductEndingHere > maxProductSoFar) {
                    maxProductSoFar = maxProductEndingHere;
                }
            }
            Console.WriteLine("Maximum product in a subarray is "+maxProductSoFar);
        }
    }
}
