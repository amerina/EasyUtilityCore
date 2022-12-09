using System;

namespace EasyUtilityCore
{
    public static class StringExtension
    {
        /// <summary>
        /// 忽略空格与大小写
        /// </summary>
        /// <param name="strA"></param>
        /// <param name="strB"></param>
        /// <returns></returns>
        public static bool CompareIgnoreCaseAndSpace(this string strA, string strB)
        {
            if (strA == null || strB == null)
            {
                return strA == strB;
            }
            return strA.Trim().ToLower() == strB.Trim().ToLower();
        }

        /// <summary>
        /// 超长字符串截取
        /// 处理较短字符串截取Case
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string Sub(this string str, int length, int index = 0)
        {
            if (str == null)
            {
                return str;
            }
            return str.Substring(index, Math.Min(str.Length, length));
        }
    }
}
