//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
//
//Note that you must do this in-place without making a copy of the array.
/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
static void MoveZeroes(int[] nums)
{
    var count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            nums[count] = nums[i];
            count++;
        }
    }

    while (count < nums.Length)
    {
        nums[count] = 0;
        count++;
    }
}

int[] nums = new int[5] { 0, 1, 0, 3, 12 };
MoveZeroes(nums);