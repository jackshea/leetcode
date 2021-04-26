using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 在 D 天内送达包裹的能力
    /// https://leetcode-cn.com/problems/capacity-to-ship-packages-within-d-days/
    public class P1011_CapacityToShipPackagesWithinDDays
    {
        public int ShipWithinDays(int[] weights, int D)
        {
            int left = weights.Max();
            int right = weights.Sum();
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                int realDays = Days(weights, mid);
                if (realDays > D)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }

        // 已知载重量，求所需天数
        public int Days(int[] weights, int cap)
        {
            int day = 1;
            int sum = 0;
            foreach (var weight in weights)
            {
                if (sum + weight <= cap)
                {
                    sum += weight;
                }
                else
                {
                    sum = weight;
                    day++;
                }
            }

            if (sum > cap)
            {
                day++;
            }

            return day;
        }
    }
}