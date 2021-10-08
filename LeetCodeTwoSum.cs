using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndProblemSolving
{
    class LeetCodeTwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int targerRemains = target - nums[i];
                int index = Array.IndexOf(nums, targerRemains);
                if (index != -1 && index != i)
                {
                    return new int[] { i, index };
                }
            }
            return null;

        }
    }
}
