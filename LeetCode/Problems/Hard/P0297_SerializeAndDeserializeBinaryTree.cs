using System.Text;
using LeetCode.Common;

namespace LeetCode.Problems.Hard;

/// 二叉树的序列化与反序列化
/// https://leetcode-cn.com/problems/serialize-and-deserialize-binary-tree/
public class Codec
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        if (root == null) return "#,";
        var sb = new StringBuilder();
        sb.Append(root.val + ",");
        sb.Append(serialize(root.left));
        sb.Append(serialize(root.right));
        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        var strings = data.Split(new[] { ',' });
        var index = 0;
        return deserialize(strings, ref index);
    }

    private TreeNode deserialize(string[] ss, ref int index)
    {
        if (ss[index] == "#") return null;

        var root = new TreeNode(int.Parse(ss[index]));
        index++;
        root.left = deserialize(ss, ref index);
        index++;
        root.right = deserialize(ss, ref index);
        return root;
    }
}