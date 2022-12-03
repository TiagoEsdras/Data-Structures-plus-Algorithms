//Given an integer array nums, find the subarray which has the largest sum and return its sum.
//https://leetcode.com/problems/maximum-subarray/

/**
 * @param {number[]} nums
 * @return {number}
 */

static int MaxSubArray(int[] nums)
{
    int maxSum = nums[0];
    int previousNumber;

    for (int i = 1; i < nums.Length; i++)
    {
        previousNumber = nums[i - 1];
        nums[i] = Math.Max(nums[i], nums[i] + previousNumber);
        maxSum = Math.Max(nums[i], maxSum);
    }

    return maxSum;
}

int[] nums = new int[9] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
Console.WriteLine(MaxSubArray(nums));