using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projEuler.Problems
{

    //Multiples of 3 and 5
    //Problem 1

    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    //The sum of these multiples is 23.

    //Find the sum of all the multiples of 3 or 5 below 1000.

    public class Problem0001 : ProblemBase
    {

        private IEnumerable<int> GetMultiplesUnder(int of, int max)
        {
            var n = 1;

            while(n < max)
            {
                if (n % of == 0)
                    yield return n;
                n++;
            }
        }

        public override void Run()
        {
            var max = 1000;
            var multiples3 = GetMultiplesUnder(of:3, max);
            var multiples5 = GetMultiplesUnder(of:5, max);
            var multiples15 = GetMultiplesUnder(of: 15, max);

            var total = multiples3.Sum() + multiples5.Sum() - multiples15.Sum();

            Console.Write(total);
        }
    }
}
