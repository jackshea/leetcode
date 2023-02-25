namespace LeetCode.Problems.Easy;

/// 增减字符串匹配
/// https://leetcode-cn.com/problems/di-string-match/
public class P0942_DiStringMatch
{
    public int[] DiStringMatch(string S)
    {
        var min = 0;
        var max = S.Length;
        var ans = new int[S.Length + 1];
        for (var i = 0; i < S.Length; i++)
            if (S[i] == 'D')
                ans[i] = max--;
            else if (S[i] == 'I') ans[i] = min++;

        ans[S.Length] = min;
        return ans;
    }
}