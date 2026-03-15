using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class MakeThreeStringsEqual
    {
        public int FindMinimumOperations(string s1, string s2, string s3)
        {
            int s1Size = s1.Length;
            int s2Size = s2.Length;
            int s3Size = s3.Length;

            int commonCount = 0;
            int Output = 0;

            int totalStringLength = s1Size + s2Size + s3Size;

            int shortString = Math.Min(s1Size, Math.Min(s2Size, s3Size));

            for (int i = 0; i < shortString; i++)
            {
                if (s1[i] == s2[i] && s2[i] == s3[i])
                {
                    commonCount++;
                }
                else
                {
                    break;
                }
            }

            if (commonCount == 0)
            {
                return -1;
            }

            Output = totalStringLength - commonCount * 3;

            return Output;
        }
    }
}
