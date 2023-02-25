namespace LeetCode.Problems.Medium;

/// 复数乘法
/// https://leetcode-cn.com/problems/complex-number-multiplication/
public class P0537_ComplexNumberMultiplication
{
    public string ComplexNumberMultiply(string a, string b)
    {
        var ca = Complex.Parse(a);
        var cb = Complex.Parse(b);
        var ans = ca.Multiply(cb);
        return ans.ToString();
    }

    public class Complex
    {
        public int a;
        public int b;

        public static Complex Parse(string input)
        {
            var split = input.Split('+');
            var ans = new Complex();
            ans.a = int.Parse(split[0]);
            ans.b = int.Parse(split[1].Substring(0, split[1].Length - 1));
            return ans;
        }

        public Complex Multiply(Complex other)
        {
            var ans = new Complex();
            ans.a = a * other.a - b * other.b;
            ans.b = a * other.b + b * other.a;
            return ans;
        }

        public override string ToString()
        {
            return $"{a}+{b}i";
        }
    }
}