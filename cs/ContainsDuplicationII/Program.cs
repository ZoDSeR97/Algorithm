/*
Given an integer array nums and an integer k, return true 
if there are two distinct indices i and j in the array 
such that nums[i] == nums[j] and abs(i - j) <= k.

Example 1:
Input: nums = [1,2,3,1], k = 3
Output: true

Example 2:
Input: nums = [1,2,3,1,2,3], k = 2
Output: false
*/

namespace ContainsDuplicationII;

class Program
{
    public static bool Solution(int[] nums, int k)
    {
        /**
        Similar to original problem but we use dictionary to memorize indice too
        Time: O(n)
        Space: O(n)
        */
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]) && i - dict[nums[i]] <= k)
                return true;
            dict[nums[i]] = i;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Solution([1, 2, 3, 1], 3));
    }
}
