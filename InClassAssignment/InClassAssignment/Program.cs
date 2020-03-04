using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //User inputs height and is stored in variable userHeight
            Console.WriteLine("Please enter your height in inches");
            int userHeight = int.Parse(Console.ReadLine());

            //User inputs weight and is stored in variable bMI
            Console.WriteLine("Please Enter your weight in pounds: ");
            float userData = float.Parse(Console.ReadLine());

            //BMI value is determined in this formula 
            float bMI = (userData * 703)/(userHeight * userHeight );
            
            // Throughout the if statements the bMI will be classified in the appropriate criteria by the value bMI
            //Severe Thinness
            if (bMI < 16)
                Console.WriteLine("You are classified Severe Thinness.");
            //Moderate Thinness
            if (bMI >= 16 && bMI <= 16.999)
                //if (bMI <=16.999) <-- Remove this
                Console.WriteLine("You are Classified as Moderate Thinness. ");
            //Mild thinness
            if (bMI >= 17 && bMI <= 18.499)
               // if (bMI <=18.499) <-- Remove this
                    Console.WriteLine("You are Classified as Mild thinness. ");
            //Mormal weight
            if (bMI >= 18.5 && bMI <= 24.99)
                //if (bMI <= 24.99) <-- Remove this
                Console.WriteLine("You are Classified as Normal weight. ");
            //Overweight
            if (bMI >= 25 && bMI <= 29.99)
                // if (bMI <= 29.99) <-- Remove this
                Console.WriteLine("You are Classified as Overweight ");
            //Obese class I
            if (bMI >= 30 && bMI <= 34.9)
                // if (bMI <=34.9) <-- Remove this
                Console.WriteLine("You are Classified as Obese class I ");
            //Obese class II
            if (bMI >= 35 && bMI <= 40)
                //if (bMI <= 40) <-- Remove this
                Console.WriteLine("You are Classified as Obese class II ");
            //Obese class III
            else if (bMI > 40)
                    Console.WriteLine("You are classified as Obese class III ");
            Console.WriteLine("Thank you for your submission!");

            
                

            
                

            
        }

    }
}
