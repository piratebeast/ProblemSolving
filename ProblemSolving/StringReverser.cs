using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class StringReverser
    {
        public string Reverse(string stringInput) 
        {
            stringInput = stringInput.Trim();
            
            char[] array = stringInput.ToCharArray();

            for (int i = 0; i <array.Length ; i++) 
            {
                char temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            string reversedString = new string(array);

            return reversedString;
        }
    }
}
