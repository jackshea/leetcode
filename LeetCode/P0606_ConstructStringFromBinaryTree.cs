using System.Text;
using LeetCode.Problems;

namespace LeetCode
{
    /// 根据二叉树创建字符串
    /// https://leetcode-cn.com/problems/construct-string-from-binary-tree/
    public class P0606_ConstructStringFromBinaryTree
    {
        private StringBuilder result = new StringBuilder();

        public string Tree2str(TreeNode t)
        {
            if (t == null)
            {
                return "";
            }
            Traval(t);
            result.Remove(0, 1);
            result.Remove(result.Length - 1, 1);
            return result.ToString();
        }

        public void Traval(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            result.Append('(');
            result.Append(node.val);
            if (node.left == null && node.right != null)
            {
                result.Append("()");
            }
            Traval(node.left);
            Traval(node.right);
            result.Append(')');
        }
    }
}