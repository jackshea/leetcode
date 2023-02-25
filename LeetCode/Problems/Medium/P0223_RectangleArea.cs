using System;

namespace LeetCode.Problems.Medium;

/// 矩形面积
/// https://leetcode-cn.com/problems/rectangle-area/
public class P0223_RectangleArea
{
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
    {
        int area1 = (C - A) * (D - B), area2 = (G - E) * (H - F);

        //无重叠
        if (C <= E || F >= D || B >= H || A >= G) return area1 + area2;
        int topX = Math.Min(G, C), topY = Math.Min(H, D);
        int bottomX = Math.Max(E, A), bottomY = Math.Max(B, F);
        return area1 - (topX - bottomX) * (topY - bottomY) + area2;
    }
}