namespace LeetCode.Problems.Easy;

/// 仅仅反转字母
/// https://leetcode-cn.com/problems/reverse-only-letters/
public class P0917_ReverseOnlyLetters
{
    public string ReverseOnlyLetters(string S)
    {
        var charArray = S.ToCharArray();
        var left = 0;
        var right = charArray.Length - 1;
        while (left < right)
        {
            if (!char.IsLetter(charArray[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetter(charArray[right]))
            {
                right--;
                continue;
            }

            if (charArray[left] != charArray[right])
            {
                var temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
            }

            left++;
            right--;
        }

        return new string(charArray);
    }
}