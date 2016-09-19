using System;

namespace distance_caluclator_Csharp {
    /// <summary>
    /// Class that contains our main function
    /// </summary>
    class Program {

        /// <summary>
        /// Our main function where we will welcome the user and do all of our calculations
        /// </summary>
        static void Main(string[] args) {
            float point1X = 0;
            float point1Y = 0;
            float point2X = 0;
            float point2Y = 0;
            float deltaX = 0;
            float deltaY = 0;
            float a;
            float b;
            float distance;
            float angle;
            bool invalidInput = false;

            Console.WriteLine("Welcome user!");
            Console.WriteLine("This application will calculate the distance and angle between two points");

            // Error checking to ensure that the user enters a number
            do {
                if (invalidInput == true) {
                    Console.WriteLine("This is not a valid input! Only numbers are allowed");
                }

                /// <summary>
                /// Set invalid input to true. This way, if we loop through this do statement again, we will display a
                /// message telling the user that their input was invalid the first time
                /// </summary>
                invalidInput = true;
                Console.WriteLine("Please enter point 1's x-coordinate: ");

                // If the input given is not a float, loop through this do statement again
            } while (!float.TryParse(Console.ReadLine(), out point1X));

            // Reinitialize invalidInput for the next input
            invalidInput = false;

            // Error checking to ensure that the user enters a number
            do {
                if (invalidInput == true) {
                    Console.WriteLine("This is not a valid input! Only numbers are allowed");
                }

                /// <summary>
                /// Set invalid input to true. This way, if we loop through this do statement again, we will display a
                /// message telling the user that their input was invalid the first time
                /// </summary>
                invalidInput = true;
                Console.WriteLine("Please enter point 1's y-coordinate: ");

                // If the input given is not a float, loop through this do statement again
            } while (!float.TryParse(Console.ReadLine(), out point1Y));

            // Reinitialize invalidInput for the next input
            invalidInput = false;

            // Error checking to ensure that the user enters a number
            do {
                if (invalidInput == true) {
                    Console.WriteLine("This is not a valid input! Only numbers are allowed");
                }

                /// <summary>
                /// Set invalid input to true. This way, if we loop through this do statement again, we will display a
                /// message telling the user that their input was invalid the first time
                /// </summary>
                invalidInput = true;
                Console.WriteLine("Please enter point 2's x-coordinate: ");

                // If the input given is not a float, loop through this do statement again
            } while (!float.TryParse(Console.ReadLine(), out point2X));

            // Reinitialize invalidInput for the next input
            invalidInput = false;

            // Error checking to ensure that the user enters a number
            do {
                if (invalidInput == true) {
                    Console.WriteLine("This is not a valid input! Only numbers are allowed");
                }

                /// <summary>
                /// Set invalid input to true. This way, if we loop through this do statement again, we will display a
                /// message telling the user that their input was invalid the first time
                /// </summary>
                invalidInput = true;
                Console.WriteLine("Please enter point 2's y-coordinate: ");

                // If the input given is not a float, loop through this do statement again
            } while (!float.TryParse(Console.ReadLine(), out point2Y));

            // Reinitialize invalidInput for the next input
            invalidInput = false;

            /// <summary>
            /// Set a and b equal to Y squared and x squared respectively
            /// Theese values will be used for our pythagorean theorem calculation later on
            /// </summary>
            deltaY = point2Y - point1Y;
            a = deltaY * deltaY;
            deltaX = point2X - point1X;
            b = deltaX * deltaX;

            /// <summary>
            /// Using the pythagorean theorem, distance c = (a^2 + b^2)^(1/2).
            /// We must cast the result as a float because the Math class normally returns a double
            /// </summary>
            distance = (float)Math.Sqrt(a + b);
            angle = (float)Math.Atan2(deltaY, deltaX) * (float)(180 / Math.PI);

            /// Take special note of how we format our string to only display 3 decimal places using {0:00.00}
            Console.WriteLine("The distance between point 1 and 2 is: {0:0.000}", distance);
            Console.WriteLine("The angle (in degrees) between point 1 and 2 is: {0:0.000}°", angle);
            Console.WriteLine("Thank you for using this application! :) Press any key to exit.");
            Console.ReadKey();
        }
    }
}
