namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 39. 数组中出现次数超过一半的数字
    /// https://leetcode-cn.com/problems/shu-zu-zhong-chu-xian-ci-shu-chao-guo-yi-ban-de-shu-zi-lcof/
    public class Offer39
    {
        public int MajorityElement(int[] nums)
        {
            int n = -1;
            int count = 0;
            foreach (var num in nums)
            {
                if (count == 0)
                {
                    n = num;
                    count = 1;
                    continue;
                }

                if (n != num)
                {
                    count--;
                }
                else
                {
                    count++;
                }
            }

            return n;
        }
    }
}