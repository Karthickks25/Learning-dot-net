using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class Sorting
    {
        public static void MainCall()
        {
            int[] inputArray = new int[] { 10, 4, 11, 7, 6, 20 };

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        int temp = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = temp;
                    }
                }
            }

            Array.ForEach(inputArray, x => Console.WriteLine(x));
            Console.ReadLine();
        }
        static void sortit(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {

                arr[i] = i + 1;
            }
        }
        public static void GFG()
        {
            // Driver code 
            int[] arr = {21,77,9, 2, 8,
                      3, 5, 4, 6, 1};
            int n = arr.Length;

            // for sort an array 
            sortit(arr, n);

            // for print all the  
            // element in sorted way 
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
