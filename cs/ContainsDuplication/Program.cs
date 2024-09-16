/*
Given an integer array nums, return true if any value appears at least twice in the array, 
and return false if every element is distinct.

Example 1:
Input: nums = [1,2,3,1]
Output: true
Explanation: The element 1 occurs at the indices 0 and 3.

Example 2:
Input: nums = [1,2,3,4]
Output: false
Explanation: All elements are distinct.

*/

namespace ContainsDuplication;

class Program
{
    public static bool Solution(int[] nums)
    {
        /**
        Fastest thinkable solution for me
        Time: O(n)
        Space: O(n)
        */
        HashSet<int> dict = new HashSet<int>();
        foreach (int num in nums)
        {
            if (!dict.Add(num))
                return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Solution([1, 2, 3, 1]));
    }
}
