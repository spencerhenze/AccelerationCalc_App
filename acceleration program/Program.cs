using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceleration_Program
{

    class Program
    {
        public static double v = 0;
        public static double t = 0;
        public static double acc = 0;
        public static string userInput = "Y";

        static void Main(string[] args)
        {

            do
            {
                try
                {
                    RunProgram();
                }
                catch
                {
                    Console.WriteLine("\nOops, Invalid entry. Please enter numbers only.");
                }

                Console.WriteLine("\nWould you like to run another calculation? (Y or N)\n");
                userInput = Console.ReadLine().ToUpper();

            } while (userInput == "Y");

            Console.WriteLine("\nThanks for using the velocity calculator!\nPress any key to exit the program.");
            Console.ReadKey();

        }

        public static double GetVelocity()
        {
            Console.WriteLine("\nEnter the Velocity in meters/second: ");
            v = Convert.ToDouble(Console.ReadLine());
            return v;
        }

        public static double GetTime()
        {
            Console.WriteLine("\nEnter the Time in seconds: ");
            t = Convert.ToDouble(Console.ReadLine());
            return t;
        }
        public static void RunProgram()
        {
            GetVelocity();
            GetTime();
            acc = v / t;
            Console.WriteLine("\n\nAcceleration : {0:0.00} meters/second^2", acc);
        }

    }


}
