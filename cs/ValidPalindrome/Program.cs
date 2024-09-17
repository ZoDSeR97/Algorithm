/**
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters 
and removing all non-alphanumeric characters, it reads the same forward and backward. 
Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

Example 1:
Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:
Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
*/

namespace ValidPalindrome;

class Program
{
    public static bool Solution(string s)
    {
        /**
        Time: O(n)
        Space: O(1) 
        */
        for (int i = 0, j = s.Length-1; j>i;)
        {
            if (!char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }
            if (char.ToLower(s[i++]) != char.ToLower(s[j--])) 
                return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Solution("A man, a plan, a canal: Panama"));
    }
}
