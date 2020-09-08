using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._2
{
    class Program
    {
        private static void Calculate(int[] nums,out int max,out int min,out double avg,out int sum)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            foreach(int n in nums)
            {
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
                sum += n;
            }
            avg = 1.0 * sum / nums.Length;
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 23, 9, 74, 69, 14, 97, 88 };
            Calculate(nums, out int max, out int min, out double avg, out int sum);
            Console.WriteLine($"max={max},min={min},average={avg},sum={sum}");
        }
    }
}
