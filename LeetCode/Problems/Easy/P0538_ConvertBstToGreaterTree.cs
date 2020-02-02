namespace LeetCode.Problems.Easy
{
    /// 把二叉搜索树转换为累加树
    /// https://leetcode-cn.com/problems/convert-bst-to-greater-tree/
    public class P0538_ConvertBstToGreaterTree
    {
        private int sum = 0;

        public TreeNode ConvertBST(TreeNode root)
        {
            Travel(root);
            return root;
        }

        private void Travel(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Travel(node.right);
            node.val += sum;
            sum = node.val;
            Travel(node.left);
        }
    }
}