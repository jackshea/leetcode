namespace LeetCode.Problems.Medium;

/// 形成两个异或相等数组的三元组数目
/// https://leetcode-cn.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/
public class P1442_CountTripletsThatCanFormTwoArraysOfEqualXor
{
    public int CountTriplets(int[] arr)
    {
        var s = new int[arr.Length + 1];
        for (var i = 0; i < arr.Length; i++) s[i + 1] = s[i] ^ arr[i];

        var ans = 0;
        for (var i = 0; i < arr.Length; i++)
        for (var j = i + 1; j < arr.Length; j++)
            if (s[i] == s[j + 1])
                ans += j - i;

        return ans;
    }
}