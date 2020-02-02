namespace LeetCode.Problems
{
    /// 建立四叉树
    /// https://leetcode-cn.com/problems/construct-quad-tree/
    public class P0427_ConstructQuadTree
    {
        public Node Construct(int[][] grid)
        {
            var root = new Node();
            root = SubConstruct(grid, 0, 0, grid[0].Length, grid.Length);
            return root;
        }

        private Node SubConstruct(int[][] grid, int x, int y, int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                return null;
            }

            bool isSame = true;
            int testValue = grid[y][x];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (testValue != grid[y + i][x + j])
                    {
                        isSame = false;
                        goto endCheck;
                    }
                }
            }

            endCheck:
            var pNode = new Node();
            if (isSame)
            {
                pNode.val = testValue != 0;
                pNode.isLeaf = true;
                return pNode;
            }

            var halfWidth = width / 2;
            var halfHeight = height / 2;

            pNode.isLeaf = false;

            pNode.topLeft = SubConstruct(grid, x, y, halfWidth, halfHeight);
            pNode.topRight = SubConstruct(grid, x + halfWidth, y, halfWidth, halfHeight);
            pNode.bottomLeft = SubConstruct(grid, x, y + halfHeight, halfWidth, halfHeight);
            pNode.bottomRight = SubConstruct(grid, x + halfWidth, y + halfHeight, halfWidth, halfHeight);
            return pNode;
        }
    }
}