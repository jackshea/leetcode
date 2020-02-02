namespace LeetCode.Problems
{
    /// 四叉树交集
    /// https://leetcode-cn.com/problems/quad-tree-intersection/
    public class P0558_QuadTreeIntersection
    {
        public Node Intersect(Node quadTree1, Node quadTree2)
        {
            if (quadTree1.isLeaf && quadTree2.isLeaf)
            {
                return new Node(quadTree1.val || quadTree2.val, true, null, null, null, null);
            }
            else if (quadTree1.isLeaf && !quadTree2.isLeaf)
            {
                if (quadTree1.val)
                {
                    return quadTree1;
                }
                else
                {
                    return quadTree2;
                }
            }
            else if (!quadTree1.isLeaf && quadTree2.isLeaf)
            {
                if (quadTree2.val)
                {
                    return quadTree2;
                }
                else
                {
                    return quadTree1;
                }
            }
            else
            {
                var node = new Node();
                node.topLeft = Intersect(quadTree1.topLeft, quadTree2.topLeft);
                node.topRight = Intersect(quadTree1.topRight, quadTree2.topRight);
                node.bottomLeft = Intersect(quadTree1.bottomLeft, quadTree2.bottomLeft);
                node.bottomRight = Intersect(quadTree1.bottomRight, quadTree2.bottomRight);

                bool isLeaf = node.topLeft.isLeaf &&
                              node.topRight.isLeaf &&
                              node.bottomLeft.isLeaf &&
                              node.bottomRight.isLeaf;

                bool isValSame = node.topLeft.val == node.topRight.val &&
                                node.topLeft.val == node.bottomLeft.val &&
                                node.topLeft.val == node.bottomRight.val;

                if (isLeaf && isValSame)
                {
                    node = node.topLeft;
                }

                return node;
            }
        }
    }
}