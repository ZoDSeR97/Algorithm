/**
You are given an integer number n, check if n is prime.
*/

namespace CheckPrime;

class Program
{
    static bool Solution(int n)
    {
        /**
        Trial Division
        Time: O(sqrt(n))
        Space: O(1)
        */
        if (n <= 1) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        /**
        Unoptimize version
        Time: O(n)
        Space: O(1) *
        for (int i = 2; i < n; i++)
        {
            if (number % i == 0)
                return false;
        }
        */
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Solution(30));
    }
}
