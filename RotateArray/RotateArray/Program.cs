//Given an nums, rotate the nums to the right by k steps, where k is non-negative.
//https://leetcode.com/problems/rotate-nums

/**
 * @param {int[]} nums
 * @param {int} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */

static void Rotate(int[] nums, int k)
{
    var numsLength = nums.Length;
    if (k == 0 || numsLength < 2) return;
    k %= numsLength;
    var take = nums.Take(numsLength - k).ToArray();
    var skip = nums.Skip(numsLength - k).ToArray();

    for (int i = 0; i < numsLength; i++)
    {
        if (i < skip.Length)
        {
            nums[i] = skip[i];
        }
        else
        {
            nums[i] = take[i - k];
        }
    }
}

int[] nums = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
Rotate(nums, 3);