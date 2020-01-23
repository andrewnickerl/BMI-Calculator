using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI_Run();
        }

        static void BMI_Run()
        {
            double height, weight;
            int age;

            //requests user input for height and validates that the input is parsed to a double
            Console.Write("Please input height in inches: ");
            double.TryParse(Console.ReadLine(), out height);
            while (height == 0)
            {
                Console.Write("Error! Please enter a number of inches: ");
                double.TryParse(Console.ReadLine(), out height);
            }
            //requests user input for weight and validates that the input is parsed to a double
            Console.Write("Please input weight in pounds: ");
            double.TryParse(Console.ReadLine(), out weight);
            while (weight == 0)
            {
                Console.Write("Error! Please enter a number of pounds: ");
                double.TryParse(Console.ReadLine(), out weight);
            }
            //requests user input for age and validates that the input is parsed to an int
            Console.Write("Please input age in years: ");
            int.TryParse(Console.ReadLine(), out age);
            while (age == 0)
            {
                Console.Write("Error! Please enter a number of years: ");
                int.TryParse(Console.ReadLine(), out age);
            }
            //pass user input to BMI() and output BMI()'s return string if age input >= 18
            if (age >= 18) Console.WriteLine(BMI(height, weight));
            else Console.WriteLine("User not above age 18.");
            Console.ReadKey();
        }

        static string BMI(double h, double w)
        {
            //calculate BMI using height and weight
            double bmi = (w * 703) / (h * h);
            //if/else series uses BMI to return a string based on the range in which BMI falls
            if (bmi < 16) return $"Your BMI is {bmi}. You must gain weight.";
            else if (bmi < 18.5) return $"Your BMI is {bmi}. You should gain weight.";
            else if (bmi < 25) return $"Your BMI is {bmi}.  Maintain your weight.";
            else if (bmi < 30) return $"Your BMI is {bmi}. You should lose weight.";
            else return $"Your BMI is {bmi}. You must lose weight.";
        }
    }
}
