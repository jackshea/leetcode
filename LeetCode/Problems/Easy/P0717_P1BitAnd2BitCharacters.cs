namespace LeetCode.Problems.Easy;

/// 1比特与2比特字符
/// https://leetcode-cn.com/problems/1-bit-and-2-bit-characters/
public class P0717_P1BitAnd2BitCharacters
{
    public bool IsOneBitCharacter(int[] bits)
    {
        var count = 0;
        for (var i = bits.Length - 2; i >= 0; i--)
        {
            if (bits[i] == 0) break;

            count++;
        }

        return count % 2 == 0;
    }
}