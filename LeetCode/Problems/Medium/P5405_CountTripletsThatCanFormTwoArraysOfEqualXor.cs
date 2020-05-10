namespace LeetCode.Problems.Medium
{
    /// 形成两个异或相等数组的三元组数目
    /// https://leetcode-cn.com/contest/weekly-contest-188/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/
    public class P5405_CountTripletsThatCanFormTwoArraysOfEqualXor
    {
        public int CountTriplets(int[] arr)
        {
            int ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    int xor = 0;
                    for (int j = i; j <= k; j++)
                    {
                        xor ^= arr[j];
                    }
                    if (xor == 0)
                    {
                        ans += k - i;
                    }
                }
            }

            return ans;
        }
    }
}