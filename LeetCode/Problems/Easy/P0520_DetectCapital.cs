namespace LeetCode.Problems.Easy;

/// 检测大写字母
/// https://leetcode-cn.com/problems/detect-capital/
public class P0520_DetectCapital
{
    public bool DetectCapitalUse(string word)
    {
        if (word.Length <= 1) return true;

        if (char.IsLower(word[0]))
        {
            // 验证是否是全小写的情况 
            for (var i = 1; i < word.Length; i++)
                if (!char.IsLower(word[i]))
                    return false;

            return true;
        }

        if (char.IsUpper(word[1]))
        {
            // 验证是否是全大写的情况
            for (var i = 2; i < word.Length; i++)
                if (!char.IsUpper(word[i]))
                    return false;

            return true;
        }

        // 验证是否是首字母大写的情况
        for (var i = 2; i < word.Length; i++)
            if (!char.IsLower(word[i]))
                return false;

        return true;
    }
}