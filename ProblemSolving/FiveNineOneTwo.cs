using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class FiveNineOneTwo
    {
        // 5912 is a wired math problem, if you sort it from small to large, you will get 1259,
        // and if you sort it from large to small, you will get 9521,
        // then you will get 9521 - 1259 = 8262,
        // then you will do the same thing to 8262,
        // you will get 8826 - 2688 = 6138, then you will do the same thing to 6138,
        // you will get 8631 - 1368 = 7263, then you will do the same thing to 7263,
        // you will get 7632 - 2367 = 5265, then you will do the same thing to 5265,
        // you will get 6552 - 2556 = 3996, then you will do the same thing to 3996,
        // you will get 9963 - 3699 = 6264, then you will do the same thing to 6264,
        // you will get 6642 - 2466 = 4176, then you will do the same thing to 4176,
        // you will get 7641 - 1467 = 6174, then you will do the same thing to 6174,
        // you will get 7641 - 1467 = 6174. So after doing this process for a while,
        // we can see that we always end up with the number of "6174", which is called "Kaprekar's constant".

        //solution : first we take 5 random number and then run a loop to do the process of sorting
        //and then subtracting until we get 6174, and we can also count the number of iterations it takes to get to 6174.
        public FiveNineOneTwo() 
        {
            Random random = new Random();
            int[] randomNumber = new int[5];

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(1000, 9999); // Generate a random 4-digit number
            }

            foreach (int num in randomNumber) 
            {
                Console.WriteLine("Random Number: " + num);
                int count = 0;
                int currentNumber = num; // Start with the random number example 5912

                while (currentNumber != 6174)
                {
                    // Pad with zeros to ensure 4 digits
                    string numStr = currentNumber.ToString().PadLeft(4, '0');

                    string sortedToSmallest = string.Concat(numStr.OrderBy(c => c)); // Sort the digits from smallest to largest, for example 1259
                    string sortedToLargest = string.Concat(numStr.OrderByDescending(c => c)); // Sort the digits from largest to smallest, for example 9521

                    int smallest = int.Parse(sortedToSmallest);
                    int largest = int.Parse(sortedToLargest);

                    int result = largest - smallest; // Subtract the smaller number from the larger number, for example 9521 - 1259 = 8262

                    count++;
                    Console.WriteLine("Iteration " + count + ": " + largest + " - " + smallest + " = " + result);

                    currentNumber = result; // Update for next iteration
                }

                Console.WriteLine("Reached Kaprekar's constant (6174) in " + count + " iterations\n");
            }
        }
    }
}
