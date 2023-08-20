using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Program
    {
        readonly int k = 90;

        static void Main(string[] args)
        {
          Program obj = new Program();
          obj.Linq55();
           
            
        }

        void distinctDemo()
        {
            string[] primeFactorsOf300 = { "abc", "nmb", "tre", "abc", "ghy" };
            var uniqueFactors = primeFactorsOf300.Distinct();
            foreach (var result in uniqueFactors)
                Console.WriteLine("There are {0} unique string", result);
        }

        public void Linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }
        }

        public void Linq55()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords =
                from w in words
                orderby w
                select w;
            var wordList = sortedWords.ToList();

            Console.WriteLine("The sorted word list:");
            foreach (var w in wordList)
            {
                Console.WriteLine(w);
            }
        }
    }
}
