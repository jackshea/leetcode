namespace LeetCode.Problems
{
    /// 机器人能否返回原点
    /// https://leetcode-cn.com/problems/robot-return-to-origin/
    public class P0657_RobotReturnToOrigin
    {
        public bool JudgeCircle(string moves)
        {
            int h = 0;
            int v = 0;
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'R':
                        h++;
                        break;
                    case 'L':
                        h--;
                        break;
                    case 'U':
                        v++;
                        break;
                    case 'D':
                        v--;
                        break;
                }
            }

            return h == 0 && v == 0;
        }
    }
}