/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

Example 1:
Input: s = "anagram", t = "nagaram"
Output: true

Example 2:
Input: s = "rat", t = "car"
Output: false
*/

namespace ValidAnagram;

class Program
{
    public static bool Solution(string s, string t)
    {
        /**
        Could use sorting algorithm to this to reduce space complexity
        Time: O(n) where n = s+t
        Space: O(n) where n = all unique characters
        */
        if (s.Length != t.Length)
            return false;
        var set = new Dictionary<char, int>();
        foreach (var c in s){
            if (!set.ContainsKey(c))
                set.Add(c, 0);
            set[c]++;
        }
        foreach (var c in t)
        {
            if (!set.ContainsKey(c) || set[c] == 0)
                return false;
            set[c]--;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Solution("anagram", "nagaram"));
    }
}
