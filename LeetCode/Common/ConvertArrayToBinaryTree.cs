using System.Collections.Generic;
using LeetCode.Problems;
using LeetCode.Problems.Easy;

namespace LeetCode.Common
{
    public static class ConvertArrayToBinaryTree
    {
        public static TreeNode Build(int?[] values)
        {
            if (values == null || values.Length == 0 || values[0] == null)
            {
                return null;
            }

            var nodeArray = new List<TreeNode>(values.Length);
            for (int i = 0; i < values.Length; i++)
            {
                var v = values[i];
                if (v.HasValue)
                {
                    nodeArray.Add(new TreeNode(v.Value));
                }
                else
                {
                    nodeArray.Add(null);
                }
            }


            for (int i = 0; i < values.Length / 2; i++)
            {
                if (nodeArray[i] == null)
                {
                    continue;
                }

                int leftIndex = 2 * i + 1;
                if (leftIndex < values.Length)
                {
                    nodeArray[i].left = nodeArray[leftIndex];
                }

                int rightIndex = 2 * i + 2;
                if (rightIndex < values.Length)
                {
                    nodeArray[i].right = nodeArray[rightIndex];
                }
            }

            return nodeArray[0];
        }
    }
}