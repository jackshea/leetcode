namespace LeetCode.Problems.Medium;

/// 验证二叉树的前序序列化
/// https://leetcode-cn.com/problems/verify-preorder-serialization-of-a-binary-tree/
public class P0331_VerifyPreorderSerializationOfABinaryTree
{
    public bool IsValidSerialization(string preorder)
    {
        var nodes = preorder.Split(',');
        var slot = 1;
        foreach (var node in nodes)
        {
            slot--;
            if (slot < 0) return false;

            if (node != "#") slot += 2;
        }

        return slot == 0;
    }
}