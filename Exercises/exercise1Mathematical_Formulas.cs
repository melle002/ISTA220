using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1Mathematical_formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine( "Part 1- Calculate the area and circumference of a circle"); // Start of Part 1 (Calculate area and circumference of a circle)
            Console.WriteLine();
            Console.WriteLine("Enter the radius below");


                string stradius = Console.ReadLine();
                int intraradius = int.Parse(stradius);
                double circumference = 2 * Math.PI * intraradius;

            
            Console.WriteLine($"Circumference = {circumference}");


                double area = Math.PI * Math.Pow(intraradius, 2.0);

            
            Console.WriteLine($"Area = {area}"); //This completes Part 1 (Calculate area and circumference of a circle)
            Console.WriteLine();


            Console.WriteLine("Part 2- Calculate the volume of a hemisphere"); // This starts part 2 (Calculate volume of a hemisphere)


                double volume = 4 / 3.0 * Math.PI * Math.Pow(intraradius, 3) / 2;
       
            
            
            Console.WriteLine($"Volume = {volume}"); // This completes part 2 (Calculate volume of a hemisphere)
            Console.WriteLine("************************************************************************************************************");

            Console.WriteLine();
            Console.WriteLine("Part 3- Calculate the area of a triangle when given length of sides"); // This begins part 3 (Calculate the Area of a triangle given all three lengths)
            


            Console.WriteLine("Enter Side 1");

                string s1 = Console.ReadLine();
                int side1 = int.Parse(s1);
       
            Console.WriteLine("Enter side 2");

                string s2 = Console.ReadLine();
                int side2 = int.Parse(s2);

            Console.WriteLine("Enter side 3");

                string s3 = Console.ReadLine();
                int side3 = int.Parse(s3);
            
                double halfCirc = (side1 + side2 + side3)/ 2;// Part 1 of formula execution
                double areaT = Math.Sqrt( halfCirc * (halfCirc - side1) * (halfCirc - side2) * (halfCirc - side3));// Final execution of calculation

            Console.WriteLine($"Area= {areaT}");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine();

            Console.WriteLine("Part 4- Solve for a quadratic equation"); // Part 4 Quadriatic equation calculation

            Console.WriteLine("Enter Value for a:");

                string a = Console.ReadLine();
                int a1 = int.Parse(a);

            Console.WriteLine("Enter Value for b:");

                string b = Console.ReadLine();
                int b1 = int.Parse(b);

            Console.WriteLine("Enter Value for c:");

                string c = Console.ReadLine();
                int c1 = int.Parse(c);

            double posAnswer = b1 + (Math.Sqrt((b1 * b1) - (4 * a1 * c1))); // using Math.Pow method
            double negAnswer = -b1 - (Math.Sqrt((b1 * b1) - (4 * a1 * c1))); // using long hand for powers
            double posAnswer1 = posAnswer / (2 * a1);
            double negAnswer2 = negAnswer / (2 * a1);

            Console.WriteLine($"Value: {posAnswer1}, {negAnswer2}"); // answers displayed side by side

           




                    
                
            

            




        }
    }
}