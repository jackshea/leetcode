using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 检查整数及其两倍数是否存在
    /// https://leetcode-cn.com/problems/check-if-n-and-its-double-exist/
    public class P1346_CheckIfNAndItsDoubleExist
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> exist = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                var n = arr[i];
                if (exist.Contains(n * 2) || n % 2 == 0 && exist.Contains(n / 2))
                {
                    return true;
                }

                exist.Add(n);
            }

            return false;
        }
    }
}