using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class PrimeNumber
    {
        public static bool CheckPrimeNumber(int number)
        {
           if(number <= 1 ) return false;

           if(number == 2 || number == 3) return true;

           if(number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2) 
            {
                if(number % i == 0) return false;
            }
            return true;
        }
    }
}
