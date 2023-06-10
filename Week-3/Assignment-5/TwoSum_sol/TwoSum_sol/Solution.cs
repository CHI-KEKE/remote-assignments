using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum_sol
{
    internal class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null)
            {
                throw new ArgumentNullException("Null array of input.");
            }

            if (nums.Length < 2)
            {
                throw new ArgumentException("The input array must contain at least 2 elements.");
            }

            var numberIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numberIndices.TryGetValue(complement, out int complementIndex))
                {
                    return new int[] { complementIndex, i };
                }
                numberIndices[nums[i]] = i;
            }

            throw new ArgumentException("Cannot find a pair of numbers of TwoSum.");
        }

    }
}
