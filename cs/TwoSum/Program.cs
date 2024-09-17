/*
Given an array of integers nums and an integer target, 
return indices of the two numbers such that they add up to target.

Each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

namespace TwoSum;

class Program
{
    public static int[] Solution(int[] nums, int target)
    {
        /**
        Use hashmap to avoid reiterate
        Time: O(n)
        Space: O(n) 
        */
        var set = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (set.ContainsKey(target - nums[i]))
                return [i, set[target - nums[i]]];
            set[nums[i]] = i;
        }
        return [0, 0]; //should never reach here if there is a solution
    }
    static void Main(string[] args)
    {
        Console.WriteLine(String.Join(", ", Solution([2, 7, 11, 15], 9)));
    }
}
