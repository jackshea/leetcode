namespace LeetCode.Problems.Medium;

/// 形成两个异或相等数组的三元组数目
/// https://leetcode-cn.com/contest/weekly-contest-188/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/
public class P5405_CountTripletsThatCanFormTwoArraysOfEqualXor
{
    public int CountTriplets(int[] arr)
    {
        var ans = 0;
        for (var i = 0; i < arr.Length; i++)
        for (var k = i + 1; k < arr.Length; k++)
        {
            var xor = 0;
            for (var j = i; j <= k; j++) xor ^= arr[j];
            if (xor == 0) ans += k - i;
        }

        return ans;
    }
}