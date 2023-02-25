using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 模拟行走机器人
/// https://leetcode-cn.com/problems/walking-robot-simulation/
public class P0874_WalkingRobotSimulation
{
    private readonly HashSet<Vector2> obstacleSet = new();
    private Vector2 dir = new(0, 1);
    private int maxDist;
    private Vector2 pos = new(0, 0);

    public int RobotSim(int[] commands, int[][] obstacles)
    {
        foreach (var obstacle in obstacles) obstacleSet.Add(new Vector2(obstacle[0], obstacle[1]));

        foreach (var command in commands) executeCmd(command);

        return maxDist;
    }

    private void executeCmd(int command)
    {
        if (command == -1)
        {
            dir = new Vector2(dir.Y, -dir.X);
        }
        else if (command == -2)
        {
            dir = new Vector2(-dir.Y, dir.X);
        }
        else
        {
            for (var i = 0; i < command; i++)
                if (!moveStep())
                    break;

            var dist = pos.X * pos.X + pos.Y * pos.Y;
            if (maxDist < dist) maxDist = dist;
        }
    }

    private bool moveStep()
    {
        var next = pos + dir;
        if (obstacleSet.Contains(next))
            return false;

        pos = next;
        return true;
    }

    public struct Vector2
    {
        public int X;
        public int Y;

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
    }
}