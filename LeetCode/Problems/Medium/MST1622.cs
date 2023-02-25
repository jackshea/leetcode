using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 兰顿蚂蚁
/// https://leetcode-cn.com/problems/langtons-ant-lcci/
public class MST1622
{
    public IList<string> PrintKMoves(int K)
    {
        var map = new Dictionary<Position, char>();
        char[] dirc = { 'R', 'D', 'L', 'U' };
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        var dirIndex = 0;
        var pos = new Position();
        int minX = 0, minY = 0, maxX = 0, maxY = 0;
        for (var i = 0; i < K; i++)
        {
            if (map.TryGetValue(pos, out var c))
            {
                if (c == '_')
                {
                    map[pos] = 'X';
                    dirIndex = (dirIndex + 1) % 4;
                }
                else
                {
                    map[pos] = '_';
                    dirIndex = (dirIndex + 3) % 4;
                }
            }
            else
            {
                map[pos] = 'X';
                dirIndex = (dirIndex + 1) % 4;
            }

            pos = new Position { X = pos.X + dx[dirIndex], Y = pos.Y + dy[dirIndex] };
            minX = Math.Min(minX, pos.X);
            minY = Math.Min(minY, pos.Y);
            maxX = Math.Max(maxX, pos.X);
            maxY = Math.Max(maxY, pos.Y);
        }

        var lenX = maxX - minX + 1;
        var lenY = maxY - minY + 1;
        var chars = new char[lenY][];
        for (var i = 0; i < lenY; i++)
        {
            chars[i] = new char[lenX];
            for (var j = 0; j < lenX; j++)
            {
                var p = new Position { X = j + minX, Y = i + minY };
                if (map.TryGetValue(p, out var c))
                    chars[i][j] = c;
                else
                    chars[i][j] = '_';
            }
        }

        chars[pos.Y - minY][pos.X - minX] = dirc[dirIndex];
        IList<string> ans = new List<string>();
        for (var i = 0; i < lenY; i++) ans.Add(new string(chars[i]));

        return ans;
    }

    private struct Position
    {
        public bool Equals(Position other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            return obj is Position other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }

        public int X;
        public int Y;
    }
}