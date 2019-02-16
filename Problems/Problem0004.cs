using System;
using System.Collections.Generic;
using System.Text;

namespace projEuler.Problems
{
    /*
    Largest palindrome product
Problem 4

A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.

    */
    public class Problem0004 : ProblemBase
    {


        bool IsPalindrome(long value)
        {
            long reverse(long v)
            {
                var rev = 0L;

                while (v > 0)
                {
                    rev = rev * 10 + v % 10;
                    v /= 10;
                }


                return rev;

            }

            return value == reverse(value);
            //var repr = value.ToString();
            //var i = 0;
            //var l = repr.Length - 1;

            //while (i <= l)
            //{
            //    if (repr[i] != repr[l])
            //        return false;
            //    i++;
            //    l--;
            //}

            //return true;
        }

        long FindLargestPalindrome(out int v1, out int v2)
        {
            var largest = 0;
            var f1 = 999;
            var wm = 99;

            v1 = v2 = 0;
            while (f1 > wm)
            {
                int f2 = f1;
                while (f2 > wm)
                {
                    var product = f1 * f2;
                    if (IsPalindrome(product) && product > largest)
                    {
                        largest = product;
                        wm = f2;
                        v1 = f1;
                        v2 = f2;
                    }
                    f2--;
                }
                f1--;
            }
            
            

            return largest;
        }
        public override void Run()
        {
            var pali = FindLargestPalindrome(out int v1, out int v2);

            Console.WriteLine($"{pali} {v1} {v2}");
            //Console.WriteLine(IsPalindrome(1));
            //Console.WriteLine(IsPalindrome(21));
            //Console.WriteLine(IsPalindrome(1221));
        }
    }
}
