using System;
namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                try
                {
                    Console.WriteLine("What is your height in metre: ");
                    double user_height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is your weight in kliograms: ");
                    double user_weight = Convert.ToDouble(Console.ReadLine());
                    double height_square = user_height * 2;
                    double user_bmi = user_weight / height_square;
                    Console.WriteLine("Your BMI is: " + String.Format("{0:0.00}", user_bmi));
                    continue;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter detail correctly");
                    continue;
                }
            }
        }
    }
}



            



        

