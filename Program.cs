using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_Two
{
    class Program
    {
        //main method
        static void Main(string[] args)
        {
            //displays a message and takes the user input
            Console.Write("Please enter a number:");
            //stores the user input as a variable called input
            int input = Convert.ToInt32(Console.ReadLine());
            //declaring a variable called currentNum
            int currentNum = 1;
            //declaring a variable called numPrime
            int numPrimes = 0;

            //do makes sure that the below is always run at least once
            do
            {
                //one is added onto the currentNum
                currentNum++;

                //if statement sets a condition that calls the function isPrime with currentNum as a variable
                if (isPrime(currentNum) == true)
                {
                    //if the function comes back with true it adds one to the numPrime variable
                    numPrimes++;
                }

            }
            //while makes sure that the do is run up to the inputted number
            //it will stop whem the input is equal to the numPrimes variable
            while (numPrimes < input);
            
            //once stopped the value of the currentNum will be output
            Console.Write(currentNum);
            Console.Read();
        }

        //boolean method which is called isPrime and is called from the main method
        //it uses value from the main method and checks if they are prime numbers
        static bool isPrime(int number)
        {
            //for loop looks at the square root of the currentNum variable and checks if it is less then i 
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                //if statement takes the 2 values and sees if there is a remainder when dividing them
                if (number % i == 0)
                    //if there is no remainder it will return false and will go back up to the main method
                    return false;
            }
            //if we have loop through all the options and there is a remainder it will return true and will go back up to the main method
            return true;

        }
    }
}
        
    

