using System.Text;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 序列化和反序列化二叉搜索树
    /// https://leetcode-cn.com/problems/serialize-and-deserialize-bst/
    public class P0449_SerializeAndDeserializeBST
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            serializeDFS(root, sb);
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            int startIndex = 0;
            return deserializeDFS(data, ref startIndex);
        }

        private void serializeDFS(TreeNode root, StringBuilder sb)
        {
            if (root == null)
            {
                sb.Append("#,");
                return;
            }

            sb.Append(root.val + ",");
            serializeDFS(root.left, sb);
            serializeDFS(root.right, sb);
        }

        public TreeNode deserializeDFS(string data, ref int startIndex)
        {
            if (startIndex >= data.Length - 1)
            {
                return null;
            }

            if (data[startIndex] == '#')
            {
                startIndex += 2;
                return null;
            }

            int val = 0;
            while (data[startIndex] != ',')
            {
                val = val * 10 + (data[startIndex++] - '0');
            }

            var root = new TreeNode(val);
            startIndex++;
            root.left = deserializeDFS(data, ref startIndex);
            root.right = deserializeDFS(data, ref startIndex);
            return root;
        }
    }
}