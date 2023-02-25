namespace LeetCode.Problems.Easy;

/// 删除字符串中的所有相邻重复项
/// https://leetcode-cn.com/problems/remove-all-adjacent-duplicates-in-string/
public class P1047_RemoveAllAdjacentDuplicatesInString
{
    public string RemoveDuplicates(string S)
    {
        var len = S.Length;
        var charArray = S.ToCharArray();
        var curIndex = S.Length;
        while (curIndex >= 0)
        {
            if (curIndex >= len - 1)
            {
                curIndex--;
                continue;
            }

            if (charArray[curIndex] == charArray[curIndex + 1])
            {
                for (var j = curIndex + 2; j < len; j++) charArray[j - 2] = charArray[j];

                len -= 2;
            }

            curIndex--;
        }

        return new string(charArray, 0, len);
    }
}