using System;

namespace LeetCode.Contest.Weekly.C229;

/// 移动所有球到每个盒子所需的最小操作数
/// https://leetcode-cn.com/contest/weekly-contest-229/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/
public class P5686
{
    public int[] MinOperations(string boxes)
    {
        var ans = new int[boxes.Length];
        for (var i = 0; i < boxes.Length; i++)
            if (boxes[i] == '1')
                for (var j = 0; j < ans.Length; j++)
                    ans[j] += Math.Abs(j - i);

        return ans;
    }
}