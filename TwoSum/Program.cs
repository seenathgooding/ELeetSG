using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Example usage  
        Solution solution = new Solution();
        int[] nums = { 3, 2, 4 };
        int target = 6;
        int[] results = solution.TwoSum(nums, target);

        // Print the results  
        Console.WriteLine($"Indices: {results[0]}, {results[1]}");
    }
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] results = new int[2];

        for (int index = 0; index < nums.Length; index++)
        {
            for (int innerIndex = 0; innerIndex < nums.Length; innerIndex++) // Fixed the loop condition  
            {
                int calc = nums[index] + nums[innerIndex];
                if (index != innerIndex && (calc == target))
                {
                    results[0] = index;
                    results[1] = innerIndex;
                    return results;
                }
            }
        }

        return results;
    }
}