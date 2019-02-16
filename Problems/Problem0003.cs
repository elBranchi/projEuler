using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projEuler.Problems
{

    /*
    Largest prime factor
Problem 3

The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?


    */
    public class Problem0003 : ProblemBase
    {
        readonly long target = 600851475143;

        List<long> primes = new List<long> { 2, 3 , 5, 7};

        void AddPrime(long prime)
        {
            if (primes.Any(p => prime % p == 0))
                return;
            primes.Add(prime);
        }

        long GetLargestPrimeFactor (long v)
        {
            var factors = GetFactors(v);

            return factors.Last();
        }

        List<long> GetFactors(long v)
        {
            return GetFactors(v, new List<long>());
        }

        List<long> GetFactors(long v, List<long> factors)
        {
            if (v == 1)
                return factors;
            var lastFactor = factors.Count > 0 ? factors.Last() : 1;
            var next = lastFactor+ 1;

            while( v % next != 0)
            {
                next++;
            }
            var subV = v / next;
            factors.Add(next);
            factors = GetFactors(subV, factors);

            return factors;
        }

        public override void Run()
        {
            var factors = GetFactors(target);
            var exampleFact = GetFactors(13195);
            var largest = GetLargestPrimeFactor(target);
            Console.WriteLine(string.Join(",", factors));
            Console.WriteLine(string.Join(",", exampleFact));
            Console.WriteLine(largest);
        }
    }
}
