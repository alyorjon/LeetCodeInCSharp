using System;
namespace LeetCodeInCSharp.Easy
{
    public class _0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                // System.Console.WriteLine($"i: {i}, nums[i]: {nums[i]}");
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // System.Console.WriteLine($"j: {j}, nums[j]: {nums[j]}");
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}