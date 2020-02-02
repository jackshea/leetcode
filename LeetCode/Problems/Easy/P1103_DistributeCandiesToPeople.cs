namespace LeetCode.Problems.Easy
{
    /// 分糖果 II
    /// https://leetcode-cn.com/problems/distribute-candies-to-people/
    public class P1103_DistributeCandiesToPeople
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            var ans = new int[num_people];
            int current = 1;
            int index = 0;
            while (current <= candies)
            {
                index %= num_people;
                ans[index] += current;
                candies -= current;
                current++;
                index++;
            }

            if (candies != 0)
            {
                index %= num_people;
                ans[index] += candies;
            }

            return ans;
        }
    }
}