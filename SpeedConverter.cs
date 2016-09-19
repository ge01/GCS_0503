using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0503
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            // Variables
            int kph;        // kilometers per hour
            double mph;     // Miles per hour

            // Display the table of speeds
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                // Calculate miles per hour.
                mph = kph * CONVERSION_FACTOR;

                // Display the conversion.
                Console.WriteLine(kph + " KPH is the same as "
                    + mph + " MPH");
               
            }
            Console.ReadLine();
        }
    }
}
