using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Fibonacci
    {
        //Function that Computes Fibonicci in iterative way
        public static int Fibonacci_Iterative(int num)
        {
            //defining the first number in the sequence
            int firstNum = 0;

            //the next number is needed to determine the coming numbers in the sequence
            int nextNum = 1;
           
            for (int i = 0; i < num; i++)
            {
                // putting the first number in temporary variable
                int tempNum = firstNum; 

                //making the 1st number equal to the second number of current operation, to use it in the next operation
                firstNum = nextNum;

                // the next number equals the previous two numbers
                nextNum = tempNum + nextNum;     
            }
            return firstNum;
        }

        //Function that Computes Fibonicci in recursive way
        public static void Fibonacci_Recursive(int firstNum, int nextNum ,int i , int num)
        {
            //print the number
            Console.Write(firstNum + " ");       

            //the counter used to determine how many numbers in the sequence i need
            if (i < num)
            {
                //recursive function that computes fibonicci sequence according to the two previous numbers
                Fibonacci_Recursive(nextNum, firstNum + nextNum , i + 1 , num); 
            }
        }

        static void Main()
        {
            Console.WriteLine("Iterative Method Output");

            for (int i = 0; i < 15; i++)
            {
                //calling iterative function in for loop with the required numbers
                Console.Write(Fibonacci_Iterative(i) + " ");
            }

            Console.Write("\n");
            Console.WriteLine("Recursive Method Output");

            //calling recursive function with inputs in it
            Fibonacci_Recursive(0, 1, 1, 15);

            Console.ReadKey();
        }
    }
}
