using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject.Basis
{
    class _0001_两数之和
    {

        public static void Solution()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] recive = TwoSum(nums, target);

            Console.WriteLine("两数之和：{0},{1}", recive[0], recive[1]);
        }



        /// <summary>
        /// 给定一个整数数组 nums 和一个整数目标值 target，
        /// 请你在该数组中找出 和为目标值 的那 两个 整数，并返回它们的数组下标。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2 || nums == null)
            {
                return null;
            }

            int[] result = new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    result[0] = dic[nums[i]];
                    result[1] = i;

                    return result;
                }

                int dif = target - nums[i];

                if (!dic.ContainsKey(dif))
                {
                    dic.Add(dif, i);
                }
            }

            return result;
        }
    }
}
