using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            // 'k' is our slow pointer: it tracks the position of the last unique element
            int k = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                // If the current element is different from the last unique element...
                if (nums[i] != nums[k])
                {
                    k++;             // Move the unique pointer forward
                    nums[k] = nums[i]; // Overwrite the next slot with the new unique value
                }
            }

            // Return k + 1 because k is an index (0-based), but we need the count
            return k + 1;
        }
    }
}
