namespace LeetCode.Problems.Medium;

/// 第K个语法符号
/// https://leetcode-cn.com/problems/k-th-symbol-in-grammar/
public class P0779_KThSymbolInGrammar
{
    public int KthGrammar(int N, int K)
    {
        return Recursion(N, K - 1);
    }

    public int Recursion(int N, int K)
    {
        if (N == 1) return 0;

        var num = Recursion(N - 1, K / 2);
        if (K % 2 == 0)
            return num == 1 ? 1 : 0;
        return num == 1 ? 0 : 1;
    }
}