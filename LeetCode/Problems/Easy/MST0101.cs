namespace LeetCode.Problems.Easy
{
    /// 面试题 01.01. 判定字符是否唯一
    /// https://leetcode-cn.com/problems/is-unique-lcci/
    public class MST0101
    {
        public bool IsUnique(string astr)
        {
            bool[] contain = new bool[60];
            foreach (var c in astr)
            {
                if (contain[c - 'A'])
                {
                    return false;
                }

                contain[c - 'A'] = true;
            }

            return true;
        }
    }
}