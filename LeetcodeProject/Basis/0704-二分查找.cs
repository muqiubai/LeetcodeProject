using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject.Basis
{
    internal class _0704_二分查找
    {
        public static int Search(int[] nums, int target)
        {
            //1、
            //return RoughWay(nums, target);

            //2、
            return OptimalWay(nums, target);
        }

        /// <summary>
        /// 粗暴解算
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int RoughWay(int[] nums, int target)
        {
            int result = -1;

            if (nums.Length <= 0)
            {
                return result;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result = i;

                    return result;
                }
            }

            return result;
        }

        /// <summary>
        /// 最优-二分方式
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        public static int OptimalWay(int[] nums,int target)
        {
            int low = 0, high = nums.Length - 1;

            //记录索引对应值
            int num = 0;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                num = nums[mid];

                if (num == target)
                {
                    return mid;
                }
                else if (num > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}
