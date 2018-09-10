using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5ManipulatingArrays
{
    class ArrayManipulators
    {
        static double sum = 0;
        static double len = 0;
        static double average = 0;

        public static void Display(int[] name)
        {


            foreach (int num in name)
            {


            }
            Console.Write("\nThe Value of the Array is: [{0}]", string.Join(",", name));


        }
        public static void Total(int[] name)
        {
            len = name.Length;

            Console.Write($"Total elements: {len} ");
        }
        public static void SumElements(int[] name)
        {
            sum = name.Sum();

            Console.Write($"Sum of Elements: {sum} ");

        }
        public static void AverageElements(int[] name)
        {

            average = sum / len;
            double ConvertedNumber = Convert.ToDouble(average);//Converts average result to double

            Console.WriteLine($"Average of Elements: {average} ");


        }
        public static void Reverse(int[] name)
        {

            for (int i = name.Length - 1; i >= 0; i--)
            {

                int value = name[i];
                {


                }

            }
            Console.WriteLine("\nThe Reverse of this Array is: [{0}]", string.Join(",", name));
        }
        private static void Print(int[] name, int n)
        {
            for (int i = 0; i < n; i++)
            {

            }
            Console.WriteLine("\nThe result is: [{0}]", string.Join(",",name ));
        }

        private static void LeftRotation(int[] name, int n, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = name[0];
                for (int j = 1; j < n; j++)
                {
                    name[j - 1] = name[j];
                }

                name[n - 1] = temp;

            }

        }

        private static void SelectSort(int[] name)
        {
            int temp;

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i; j < name.Length; j++)
                {
                    if (name[i] > name[j])
                    {
                        temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;

                    }

                }

            }

        }
        private static void RightRotation(int[] name, int n, int k)
        {
            for (int i = n; i > k; i--)
            {
                int temp = name[0];
                for (int j = 1; j < n; j++)
                {
                    name[j - 1] = name[j];
                }

                name[n - 1] = temp;


            }

        }

        class Program
        {

            static void Main(string[] args)
            {

                int[] numSet1 = new int[] { 0, 2, 4, 6, 8, 10 }; //Initializes Array A
                Display(numSet1);
                Console.WriteLine();
                Total(numSet1);
                Console.WriteLine();
                SumElements(numSet1);
                Console.WriteLine();
                AverageElements(numSet1);
                Console.WriteLine();
                Console.Write("Reverse Array");
                Reverse(numSet1);
                Console.WriteLine();
                LeftRotation(numSet1, numSet1.Length, 2);
                Console.Write("Rotate Array by 2 to the left");
                Print(numSet1, numSet1.Length);







                int[] numSet2 = new int[] { 1, 3, 5, 7, 9 }; // Initializes Array B
                Console.WriteLine();
                Display(numSet2);
                Console.WriteLine();
                Total(numSet2);
                Console.WriteLine();
                SumElements(numSet2);
                Console.WriteLine();
                AverageElements(numSet2);
                Console.WriteLine();
                Console.Write("Reverse Array");
                Reverse(numSet2);
                Console.WriteLine();
                RightRotation(numSet2, numSet2.Length, 2);
                Console.Write("Rotate Array by 2 to the Right");
                Print(numSet2, numSet2.Length);



                int[] numSet3 = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }; //Initializes Array C
                Console.WriteLine();
                Display(numSet3);
                Console.WriteLine();
                Total(numSet3);
                Console.WriteLine();
                SumElements(numSet3);
                Console.WriteLine();
                AverageElements(numSet3);
                Console.WriteLine();
                Console.Write("Reverse Array");
                Reverse(numSet3);
                Console.WriteLine();
                LeftRotation(numSet3, numSet3.Length, 4);
                Console.Write("Rotate Array by 4 to the left");
                Print(numSet3, numSet3.Length);
                Console.WriteLine();
                SelectSort(numSet3);
                Console.Write("Sort the array in acsending order.");
                Print(numSet3, numSet3.Length);
                Console.WriteLine();



            }


        }
    }
}
