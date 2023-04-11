namespace LeetCode.Problems.Medium;

/// 困于环中的机器人
/// https://leetcode.cn/problems/robot-bounded-in-circle/
public class P1041_RobotBoundedInCircle
{
    public bool IsRobotBounded(string instructions)
    {
        int[][] dir = { new[] { 0, 1 }, new[] { 1, 0 }, new[] { 0, -1 }, new[] { -1, 0 } };
        var pos = new[] { 0, 0 };
        var curDirIndex = 0;
        foreach (var ins in instructions)
        {
            switch (ins)
            {
                case 'G':
                    var curDir = dir[curDirIndex];
                    pos[0] += curDir[0];
                    pos[1] += curDir[1];
                    break;
                case 'L':
                    --curDirIndex;
                    if (curDirIndex < 0)
                    {
                        curDirIndex = 3;
                    }
                    break;
                case 'R':
                    curDirIndex = (curDirIndex + 1) % 4;
                    break;
            }
        }

        return pos[0] == 0 && pos[1] == 0 || curDirIndex != 0;
    }
}