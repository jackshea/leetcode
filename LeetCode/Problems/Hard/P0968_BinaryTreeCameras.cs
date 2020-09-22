using LeetCode.Common;

namespace LeetCode.Problems.Hard
{
    /// 监控二叉树
    /// https://leetcode-cn.com/problems/binary-tree-cameras/
    public class P0968_BinaryTreeCameras
    {
        private int ans = 0;
        public int MinCameraCover(TreeNode root)
        {
            if (DFS(root) == 0)
            {
                ans++;
            }

            return ans;
        }

        /// 0-> 无法监控
        /// 1-> 可监控
        /// 2-> 有摄像头
        private int DFS(TreeNode node)
        {
            // 空节点默认认为是可监控的，这样不影响父节点是否要添加摄像头的决策。
            if (node == null)
            {
                return 1;
            }

            int left = DFS(node.left);
            int right = DFS(node.right);

            // 子节点中有一个无法监控，则根结点要加摄像头
            if (left == 0 || right == 0)
            {
                ans++;
                return 2;
            }

            // 子节点都可监控，无需加摄像头，但当前结点无法监控
            if (left == 1 && right == 1)
            {
                return 0;
            }

            // 其他情况，即子节点其中一个必有摄像头，当前结点可监控，无需加摄像头。
            return 1;
        }
    }
}