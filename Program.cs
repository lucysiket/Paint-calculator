using System;

namespace Paint_calculator
{
    internal class Program
    {
        // Note: this solution makes the assumption that the room has a rectangular shape, and that 1 litre of paint covers 6 metres^2 of area

        // Function - Returns the area of the floor
        static double floorArea(double roomWidth, double roomLength)
        {
            return roomWidth * roomLength; // Area = width x length
        }

        // Function - Returns the volume of the room
        static double roomVolume(double roomHeight, double roomWidth, double roomLength)
        {
            return roomWidth * roomLength * roomHeight;  // Volume = width x length x height
        }

        // Function - returns the amount of paint required
        static double paintRequired(double roomHeight, double roomWidth, double roomLength)
        {
            double wallArea = (2 * roomWidth * roomHeight) + (2 * roomLength * roomHeight);  // Wall SA = 2(width x height) + 2(length x height)
            return wallArea * (0.17); // Assumes that 1 litre covers 6 metres^2 - so 1 metre^2 requires 1/6 litres (approx 0.17)
        }

        /*
             * Function - checks that an input is of the correct data type (double) and returns it
             * Takes one parameter: the actual measurement to be recorded(eg: the string "width")
        */

        static double dimension(string measurement)
        {
            double x;
            while (true)
            {
                Console.WriteLine($"Enter the room's {measurement}");
                // Tries to parse what the user enters, if true, stores the value in x
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    break; //breaks out of loop
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number!");
                }
            }
            return x;
        }

        // Main program ---------------------------------------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the paint calculator\nPlease give all measurements in metres"); // Program introduction

            // Taking in user input of the room's dimensions
            double width = dimension("width");  // Width
            
            double length = dimension("length");  // Length
            
            double height = dimension("height");  // Height


            // Program output
            Console.WriteLine($"Area of the floor: {floorArea(width, length)} m^2");  // Floor area

            Console.WriteLine($"Volume of the room: {roomVolume(height, width, length)} m^3");  // Room volume

            Console.WriteLine($"Amount of paint required: {paintRequired(height, width, length)} litres");  // Paint required

            /*
             * If I had more time to refine this project, I would optimise the function which checks that user input is the correct data type
             * I would also make this solution more applicable to real life situations - in essence, account for doors, windows and skirting boards etc
             * Similarly, I would make this program a windowed application rather than being run on command line in order to improve usability
            */
        }
    }
}
