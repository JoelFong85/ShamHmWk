using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamHmWk
{
    class Sort
    {
        static void Main(string[] args)
        {
            //bubble sort
            int[] numArray = new int[] { 35, 10, 1, 8, 20, 45, 33 };

            Console.WriteLine("Original array");
            foreach (int k in numArray)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine("\n ");

            int tempNum = 0;

            Console.WriteLine("Sorted Array");
            for (int i = 0; i < numArray.Length - 1; i++)
            {

                for (int j = i + 1; j < numArray.Length; j++)
                {

                    if (numArray[i] < numArray[j])
                    {
                        tempNum = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = tempNum;
                    }
                }

                foreach (int k in numArray)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine("");
            }


        }
    }
}
