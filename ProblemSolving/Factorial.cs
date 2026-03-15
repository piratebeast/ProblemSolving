using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class Factorial
    {
        public int CalculateFactorial(int number) 
        {
            return number == 0 ? 1 : number * CalculateFactorial(number - 1);
        }
    }
}
