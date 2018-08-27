using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"-----Lets Find the Area and Circumference of a Circle Along With the Volume of a Hemisphere-----");
            Console.WriteLine();
            Console.Write("Enter the radius: ");

            double circumference;
            uint radius;
            double area;

            l1:
            try
            {

                radius = uint.Parse(Console.ReadLine());
                circumference = 2 * Math.PI * radius;
                area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine();
                Console.WriteLine($"Area = {area}");
                Console.WriteLine($"Circumference = {circumference}");
            }
            catch(FormatException fe)
            {
                Console.WriteLine("C'mon now...really? \n{0}" , fe.Message);
                Console.WriteLine($"Let's try again dummy :(");
                goto l1;
            }
            catch(Exception ex )
            {
                Console.WriteLine("ERROR: You done messed up because a radius has to be a positive integer. Come on now......YOU KNOW BETTER !\n{0}", ex.Message );
                Console.WriteLine();
                Console.WriteLine($"Let's try again dummy :(");
                goto l1;
            }
            finally
            {
                Console.WriteLine($"I apologize if feelings were hurt in the making of this program but you probably deserved it");

            }
            Console.WriteLine();
            Console.WriteLine("-----Here is the the volume of a hemisphere-----");
            Console.WriteLine();

            double volume = 4 / 3.0 * Math.PI * Math.Pow(radius, 3) / 2;

            Console.WriteLine($"The Volume of a Hemisphere = {volume}");
            Console.WriteLine();
            Console.WriteLine("-----Now Let's Find the Area of a Triangle Using Heron's Formula-----");
            Console.WriteLine();

            double tArea;
            uint sideA;
            uint sideB;
            uint sideC;
            double halfCirc;

            l2:
            try
            {
                Console.Write("Please Enter Side 1: ");

                    sideA = uint.Parse(Console.ReadLine());

                Console.Write("Please Enter Side 2: ");

                    sideB = uint.Parse(Console.ReadLine());

                Console.Write("Please Enter Side 3: ");

                sideC = uint.Parse(Console.ReadLine());

                halfCirc = (sideA + sideB + sideC) / 2;
                tArea = Math.Sqrt(halfCirc * (halfCirc - sideA) * (halfCirc - sideB) * (halfCirc - sideC));
                Console.WriteLine();
                Console.WriteLine($"Area = {tArea}");

            }
            catch (FormatException fe)
            {
                Console.WriteLine("C'mon now...really? \n{0}", fe.Message);
                Console.WriteLine($"Let's try again dummy :(");
                goto l2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: You done messed up because a radius has to be a positive integer. Come on now......YOU KNOW BETTER !\n{0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine($"Let's try again dummy :(");
                goto l2;
            }
            finally
            {
            Console.WriteLine($"I apologize if feelings were hurt in the making of this program but you probably deserved it");

            }
            Console.WriteLine();
            Console.WriteLine($"-----Now, Let's Attempt to Solve a Quadriatic Formula-----");

            uint a;
            uint b;
            uint c;
            double answer1;
            double answer2;




            l3:
            try
            {
                Console.Write($"a: ");
                    a = uint.Parse(Console.ReadLine());

                Console.Write($"b: ");
                    b = uint.Parse(Console.ReadLine());

                Console.Write($"c: ");
                    c = uint.Parse(Console.ReadLine());

                Console.WriteLine();

                answer1 = (-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
                answer2 = (-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);

                Console.WriteLine($"Value: {answer1}, {answer2}");
                Console.WriteLine();

            }
            catch (FormatException fe)
            {
                Console.WriteLine("C'mon now...really? \n{0}", fe.Message);
                Console.WriteLine($"Let's try again dummy :(");
                goto l3;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: You done messed up because a radius has to be a positive integer. Come on now......YOU KNOW BETTER !\n{0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine($"Let's try again dummy :(");
                goto l3;
            }
            finally
            {
                Console.WriteLine($"I apologize if feelings were hurt in the making of this program but you probably deserved it");

            }







        }
    }
}
