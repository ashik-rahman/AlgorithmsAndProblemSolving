using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndProblemSolving
{
    class LeetCodeTwoSum : PrintInputOutput
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
        public void CallAndPrint(int[] nums, int target)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = TwoSum(nums, target);
            watch.Stop();
            Console.WriteLine($"1. Two Sums\n" +
                              $"Input Array = {this.printInputArray(nums)} target = {target}\n" +
                              $"Result: [{results[0]}, {results[1]}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
