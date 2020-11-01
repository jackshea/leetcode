using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 能否连接形成数组
    /// https://leetcode-cn.com/contest/weekly-contest-213/problems/check-array-formation-through-concatenation/
    public class P5554
    {
        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            Dictionary<int, int[]> dic = new Dictionary<int, int[]>();
            foreach (var piece in pieces)
            {
                dic[piece[0]] = piece;
            }

            for (int i = 0; i < arr.Length;)
            {
                if (!dic.TryGetValue(arr[i], out var piece))
                {
                    return false;
                }

                for (var j = 0; j < piece.Length; j++)
                {
                    if (i >= arr.Length)
                    {
                        return false;
                    }

                    if (arr[i++] != piece[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}