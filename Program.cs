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
            //requests user input for height and weight
            Console.Write("Please input height: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Please input weight: ");
            int weight = int.Parse(Console.ReadLine());
            //pass user input to BMI() and WL BMI()'s return string
            Console.WriteLine(BMI(height, weight));
            Console.ReadKey();
        }

        static string BMI(double height, double weight)
        {
            double bmi = (weight * 703) / (height * height);
            //if/else series uses BMI to return a string based on the range in which BMI falls
            if (bmi < 16) return $"Your BMI is {bmi}. You must gain weight.";
            else if (bmi < 18.5) return $"Your BMI is {bmi}. You should gain weight.";
            else if (bmi < 25) return $"Your BMI is {bmi}.  Maintain your weight.";
            else if (bmi < 30) return $"Your BMI is {bmi}. You should lose weight.";
            else return $"Your BMI is {bmi}. You must lose weight.";
        }
    }
}
