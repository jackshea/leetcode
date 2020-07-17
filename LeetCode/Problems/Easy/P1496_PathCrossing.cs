using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 判断路径是否相交
    /// https://leetcode-cn.com/problems/path-crossing/
    public class P1496_PathCrossing
    {
        public bool IsPathCrossing(string path)
        {
            Dictionary<char, Point> direction = new Dictionary<char, Point>
            {
                {'N',new Point(0,-1) },
                {'S',new Point(0,1) },
                {'E',new Point(1,0) },
                {'W',new Point(-1,0) }
            };

            HashSet<Point> visited = new HashSet<Point>();
            Point curPos = new Point(0, 0);
            visited.Add(curPos);
            foreach (var dir in path)
            {
                curPos += direction[dir];
                if (visited.Contains(curPos))
                {
                    return true;
                }

                visited.Add(curPos);
            }

            return false;
        }

        public class Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static Point operator +(Point p1, Point p2)
            {
                return new Point(p1.X + p2.X, p1.Y + p2.Y);
            }

            protected bool Equals(Point other)
            {
                return X == other.X && Y == other.Y;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((Point)obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (X * 397) ^ Y;
                }
            }
        }
    }
}