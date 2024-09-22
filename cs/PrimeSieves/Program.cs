/**
You are given an integer number n, finding all primes up to n.
*/

namespace PrimeSieves;

class Program
{
    static List<int> Solution(int n)
    {
        /**
        Sieve of Eratosthenes algorithm
        Time: O(n log log n)
        Space: O(n)
        */
        bool[] isPrime = new bool[n+1];
        for (int i = 2; i < n+1; i++)
        {
            isPrime[i] = true;
        }

        for (int p = 2; p * p < n+1; p++)
        {
            // If isPrime[p] is not changed, then it is a prime
            if (isPrime[p])
                // Updating all multiples of p to not prime
                for (int i = p * p; i < n + 1; i += p)
                {
                    isPrime[i] = false;
                }
        }

        // Collecting all prime numbers
        List<int> primes = new List<int>();
        for (int i = 2; i < n + 1; i++)
        {
            if (isPrime[i])
                primes.Add(i);
        }

        return primes;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(String.Join(", ", Solution(30)));
    }
}
