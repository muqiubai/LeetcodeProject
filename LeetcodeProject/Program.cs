using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject.Basis;

namespace LeetcodeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //0001;
            _0001_两数之和.Solution();

            //0005;
            _0005_最长回文子串.Solution();

            //0217;
            Console.WriteLine(_0217_查重.Duplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));

            //0053
            Console.WriteLine(_0053_最大子数组和.MaxSubArray(new int[] { 5, 4, -1, 7, 8 }));

            //0704
            ShowMessage("0704:二分查找" + _0704_二分查找.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));

            Console.ReadLine();
        }


        private static void ShowMessage(object _data)
        {
            Console.WriteLine(_data);
        }
    }
}
