using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject.Basis
{
    internal class _0053_最大子数组和
    {
        public static int MaxSubArray(int[] nums)
        {
            int m = 0, maxNum = nums[0];

            foreach (var item in nums)
            {
                m = Math.Max(m + item, item);
                maxNum = Math.Max(maxNum, m);
            }

            return maxNum;
        }
    }
}
