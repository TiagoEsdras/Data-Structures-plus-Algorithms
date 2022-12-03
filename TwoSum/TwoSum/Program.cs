/*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.*/

//https://leetcode.com/problems/two-sum/description/

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

static int[] TwoSum(int[] nums, int target)
{
    var dict = new Dictionary<int, int>();
    int[] response = new int[2];

    for (int i = 0; i < nums.Length; i++)
    {
        int valueToTarget = target - nums[i];
        if (dict.ContainsKey(nums[i]))
        {
            response[0] = dict[nums[i]];
            response[1] = i;
        }
        else if(!dict.ContainsKey(valueToTarget))
        {
            dict.Add(valueToTarget, i);
        }
    }
    return response;
}

int[] nums = new int[17] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };

Console.WriteLine(TwoSum(nums, 11));