using System;

public class Program
{
    public static void Main (string[] args)
    {
        Solution solution = new Solution();
        int[] nums = [1, 2, 3, 4];
        int ans = solution.MaximumProduct(nums);
        Console.WriteLine(ans);
    }

}

public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        int calc = 0;
        int compare = 0; 
        for (int index = 0; index < nums.Length; index++)
        {
            for (int innerIndex = 0; innerIndex < nums.Length; innerIndex++)
            {

                if (index < nums.Length)
                {
                    calc = nums[index] * nums[innerIndex + 1];
                    if ((calc > compare))
                    {
                        compare = calc;
                    }
                }
            }

        }
        return compare;
    }
}

int min1 = int.MaxValue, min2 = int.MaxValue;
int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;

foreach (var n in nums)
{
    if (n <= min1)
    {
        min2 = min1;
        min1 = n;
    }
    else if (n <= min2)
    { 
        min2 = n;
    }

    if (n >= max1)
    { 
        max3 = max2;
        max2 = max1;
        max1 = n;
    }
    else if (n >= max2)
    {  
        max3 = max2;
        max2 = n;
    }
    else if (n >= max3)
    {   
        max3 = n;
    }
}
return Math.Max(min1 * min2 * max1, max1 * max2 * max3);  
    }  