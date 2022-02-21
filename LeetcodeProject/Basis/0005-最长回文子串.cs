using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject.Basis
{
    class _0005_最长回文子串
    {

        public static void Solution()
        {
            string s = "babad";

            string recive = LongestPalindrome(s);

            Console.WriteLine("最长回文子串：{0}", recive);
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return null;
            }

            if (s.Length == 1)
            {
                return s;
            }

            string result = "";

            //拓展
            int extension = s.Length * 2 - 1;

            for (int i = 0; i < extension; i++)
            {
                double mid = i / 2.0;

                int before = (int)(Math.Floor(mid));
                int after = (int)(Math.Ceiling(mid));

                while (before >= 0 && after < s.Length)
                {
                    if (s[before] != s[after])
                    {
                        break;
                    }

                    before--;
                    after++;
                }

                //获取已比对过的回文子串的长度
                int len = after - before - 1;

                if (len > result.Length)
                {
                    result = s.Substring(before + 1, len);
                }
            }

            return result;
        }
    }
}
