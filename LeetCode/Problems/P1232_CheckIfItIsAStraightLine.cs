namespace LeetCode.Problems
{
    /// 缀点成线
    /// https://leetcode-cn.com/problems/check-if-it-is-a-straight-line/
    public class P1232_CheckIfItIsAStraightLine
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 2)
            {
                return true;
            }

            int deltaX1 = coordinates[1][0] - coordinates[0][0];
            int deltaY1 = coordinates[1][1] - coordinates[0][1];
            for (int i = 2; i < coordinates.Length; i++)
            {
                int deltaXn = coordinates[i][0] - coordinates[0][0];
                int deltaYn = coordinates[i][1] - coordinates[0][1];
                if (deltaX1 * deltaYn != deltaY1 * deltaXn)
                {
                    return false;
                }
            }

            return true;
        }
    }
}