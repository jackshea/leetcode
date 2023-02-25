namespace LeetCode.Problems.Easy;

/// 生成每种字符都是奇数个的字符串
/// https://leetcode-cn.com/problems/generate-a-string-with-characters-that-have-odd-counts/
public class P1374_GenerateAStringWithCharactersThatHaveOddCounts
{
    public string GenerateTheString(int n)
    {
        var cs = new char[n];
        for (var i = 0; i < n; i++) cs[i] = 'a';

        if (n % 2 == 0) cs[0] = 'b';
        return new string(cs);
    }
}