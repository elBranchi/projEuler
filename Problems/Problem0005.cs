using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projEuler.Problems
{

//Smallest multiple
//Problem 5

//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


    public class Problem0005 : ProblemBase
    {

        long GetSmallestDivisible(int upperValue)
        {
            var smallest = 1L;


            var factors = Enumerable.Range(2, upperValue - 1).ToArray();


            for (var i = 0; i < factors.Length; i++){

                var curr = factors[i];
                for(var j = i+1; j < factors.Length; j++)
                {
                    if (factors[j] % curr == 0)
                        factors[j] = factors[j] / curr;
                }
            }
            Console.WriteLine(string.Join(":", factors));
            smallest = factors.Aggregate(smallest, (p, f) => p * f);
            return smallest;
        }

        public override void Run()
        {
            var divisible = GetSmallestDivisible(20);
            Console.WriteLine(divisible);

        }
    }
}
