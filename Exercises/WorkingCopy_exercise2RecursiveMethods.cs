using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            double sum = 0;
            int stop = 10;
            get_average(sum, start, stop);
            
            
            
        }

        private static void get_average(double sum, int start, int stop)
        {
            start++;
            // ask user for grades one at a time
            Console.WriteLine("Enter Grade: ");


            // read users input
            double grade = Convert.ToDouble(Console.ReadLine());
                      
                
            
                          
                        
            // Displays average and provides letter grade
            sum = grade + sum;
            if(start < stop)
            {
                get_average(sum, start, stop);
            }
            else
            {
                double average = sum / stop;
                Console.WriteLine(average);
                if (average >= 90)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (average >= 80)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (average >= 70)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (average >= 60)
                {
                    Console.WriteLine("Grade: D");
                }
                else if (average < 60)
                {
                    Console.WriteLine("Grade: F");
                }
            }
            

        }
    }
}
