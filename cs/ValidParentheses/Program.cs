/**
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
determine if the input string is valid.

An input string is valid if:
    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.

*/

namespace ValidParentheses;

class Program
{
    public static bool Solution(string s)
    {
        /**
        Time: O(n)
        Space: O(n) 
        */
        var stack = new Stack<char>();
        var map = new Dictionary<char, char>() 
        {
            {']', '['},
            {')', '('},
            {'}', '{'}
        };
        foreach (var c in s) 
        {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else if (stack.Count == 0 || stack.Pop() != map[c])
                return false;
        }
        
        return stack.Count == 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Solution(")"));
    }
}
