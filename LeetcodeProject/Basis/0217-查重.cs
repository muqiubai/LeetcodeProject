using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject.Basis
{
    internal class _0217_查重
    {
        private static List<int> lists = new List<int>();
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 0)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (lists.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    lists.Add(nums[i]);
                }
            }

            return false;
        }


        public static bool Duplicate(int[] nums)
        {
            if (nums.Length <= 0)
            {
                return false;
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
