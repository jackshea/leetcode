namespace LeetCode.Problems.Easy
{
    /// 设计停车系统
    /// https://leetcode-cn.com/problems/design-parking-system/
    public class ParkingSystem
    {
        private int[] park;
        public ParkingSystem(int big, int medium, int small)
        {
            park = new[] { 0, big, medium, small };
        }

        public bool AddCar(int carType)
        {
            if (park[carType] > 0)
            {
                park[carType]--;
                return true;
            }

            return false;
        }
    }
}