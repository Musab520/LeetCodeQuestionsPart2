using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPart2
{
    class Question2
    {
        public static void Main()
        {
            int []nums = { 0, 1, 2, 4 };
            Console.WriteLine(MissingNumber(nums));
        }
        public static int MissingNumber(int[] nums)
        {
            int sum = 0;
            for (int i=0;i<nums.Length+1; i++)
            {
                sum += i;
            }
            foreach(int i in nums)
            {
                sum -= i;
            }
           
            return sum;
        }
    }
  
}
