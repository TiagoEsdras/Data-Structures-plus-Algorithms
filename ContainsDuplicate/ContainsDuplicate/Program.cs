//Given an integer array nums, return true if any value appears at least twice in the array,
//and return false if every element is distinct.

/**
 * @param {int[]} nums
 * @return {bool}
 */

static bool ContainsDuplicate(int[] nums)
{
    var numsWithOutRepeatNumbers = nums.Distinct().ToArray();
    return numsWithOutRepeatNumbers.Length < nums.Length;
}

int[] nums = new int[3] { 1, 3, 4 };
Console.WriteLine(ContainsDuplicate(nums));