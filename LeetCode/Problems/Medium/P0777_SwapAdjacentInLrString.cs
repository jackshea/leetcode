namespace LeetCode.Problems.Medium;

/// 在LR字符串中交换相邻字符
/// https://leetcode-cn.com/problems/swap-adjacent-in-lr-string/
public class P0777_SwapAdjacentInLrString
{
    public bool CanTransform(string start, string end)
    {
        var n = start.Length;
        int i = -1, j = -1;
        while (++i < n && ++j < n)
        {
            while (i < n && start[i] == 'X') i++;

            while (j < n && end[j] == 'X') j++;

            if ((i < n) ^ (j < n)) return false;

            if (i < n && j < n)
                if (start[i] != end[j] || (start[i] == 'L' && i < j) || (start[i] == 'R' && i > j))
                    return false;
        }

        while (++i < n)
            if (start[i] != 'X')
                return false;

        while (++j < n)
            if (end[j] != 'X')
                return false;

        return true;
    }
}