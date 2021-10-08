using System;

namespace AlgorithmsAndProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Two Sum LeetCode

            var instance = new LeetCodeTwoSum();
            instance.CallAndPrint(new int[] { 2, 7, 11, 15 }, 18);

            instance.CallAndPrint(new int[] {2, 7, 11, 15}, 9);

            #endregion

            //Console.ReadLine();
        }
    }
}
