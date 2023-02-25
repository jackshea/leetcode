using System.Linq;

namespace LeetCode.Problems.Easy;

/// 强密码检验器 II
/// https://leetcode.cn/problems/strong-password-checker-ii/
public class P2299_StrongPasswordCheckerII
{
    public bool StrongPasswordCheckerII(string password)
    {
        if (password.Length < 8) return false;

        var set = "!@#$%^&*()-+".ToHashSet();

        var ans = 0;
        var chk6 = true;
        for (var i = 0; i < password.Length; i++)
        {
            var c = password[i];
            if (c >= 'a' && c <= 'z') ans |= 1;
            if (c >= 'A' && c <= 'Z') ans |= 0b10;
            if (c >= '0' && c <= '9') ans |= 0b100;
            if (set.Contains(c)) ans |= 0b1000;
            if (i < password.Length - 1 && c == password[i + 1]) chk6 = false;
        }

        return ans == 0b1111 && chk6;
    }
}