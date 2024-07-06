using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Part3
{
    public class Buzz
    {
        public static void Baffle(string blimp)
        {
            Console.WriteLine(blimp);   // Task2: Statement 4 - Output "rattle"
            Zippo("ping", -5);          // Task2: Statement 5 - Called Zippo method
        }
        /* Task3: The value of blimp is "rattle" when Baffle gets invoked,
         * the main method set "rattle" as one of the parameter which was given to Zippo as the strinq quince parameter.
         * In the Baffle method there is a string blimp parameter, it takes the string parameter from Zippo and Output "rattle" */

        public static void Zippo(string quince, int flag)
        {
            if (flag < 0)
            {
                Console.WriteLine(quince + " zoop");    // Task2: Statement 6 - Output "ping"" zoop"
            }
            else
            {
                Console.WriteLine("ik");                // Task2: Statement 2 - Output "ik"
                Baffle(quince);                         // Task2: Statement 3 - Called Baffle method
                Console.WriteLine("boo-wa-ha-ha");      // Task2: Statement 7 - Output "boo-wa-ha-ha"
            }
        }

        /* Task4: The Output are as follow -
         * ik
         * rattle
         * ping zoop
         * boo-wa-ha-ha */

        public static void Main(string[] args)
        {
            Zippo("rattle", 13);    // Task1: Statement 1 that will execute first - Called Zippo method
        }
    }
}
