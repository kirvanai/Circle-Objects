using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    public class Validator
    {
        public static double DoubleValidator (string input)
        {

            bool goOn = true;

            while (goOn = true)
            {
                try
                {
                    double output = double.Parse(input);
                    return output;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input a number only!");
                    input = Console.ReadLine();
                }
            }
            return -1;
        }

        public static string YesOrNoValidator(string input)
        {
            input = input.ToLower();
            while (input != "y" && input != "n")
            {
                Console.WriteLine("Invalid response. y/n?");
                input = Console.ReadLine();
            }
            return input;

        }

    }
}
