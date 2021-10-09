using System;
using System.Collections;
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
        public int[] TwoSumWithHashTable(int[] nums, int target)
        {
            //to get O(1) solution, need to use reverse hashtable -> key become value and value become key
            var hashList = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                int targerRemains = target - nums[i];
                if(hashList.ContainsKey(targerRemains)){
                    return new int[]{i,(int)hashList[targerRemains]}; //hashTable[key] returns object that's why conversion needed
                }else{
                    if(!hashList.ContainsKey(nums[i])){
                        hashList[nums[i]]= i;
                    }
                }
            }
            return null;
        }
        public void CallAndPrint(int[] nums, int target)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = TwoSumWithHashTable(nums, target);
            watch.Stop();
            Console.WriteLine($"1. Two Sums\n" +
                              $"Input Array = {this.printInputArray(nums)} target = {target}\n" +
                              $"Result: [{results[0]}, {results[1]}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
