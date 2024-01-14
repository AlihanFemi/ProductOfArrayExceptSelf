using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfArrayExpectSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            int[] res = ProductExceptSelf(nums);
            Console.WriteLine(String.Join(", ", res));
        }

        static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0, prev = 1; i < nums.Length; i++)
            {
                result[i] = prev;
                prev = nums[i] * prev;
            }

            for(int i = nums.Length - 1, prev = 1; i >= 0; i--)
            {
                result[i] *= prev;
                prev *= nums[i];
            }

            return result;
        }
    }
}
