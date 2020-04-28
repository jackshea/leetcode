namespace LeetCode.Problems.Medium
{
    /// 区域和检索 - 数组可修改
    /// https://leetcode-cn.com/problems/range-sum-query-mutable/
    public class NumArray
    {
        private SegTreeNode[] tree;
        private int[] nums;

        public NumArray(int[] nums)
        {
            this.nums = nums;
            if (nums == null || nums.Length == 0)
            {
                return;
            }
            tree = new SegTreeNode[4 * this.nums.Length + 1];
            BuildTree(1, 1, nums.Length);
        }

        public void Update(int i, int val)
        {
            Update(1, i + 1, val);
        }

        public int SumRange(int i, int j)
        {
            return Search(1, i + 1, j + 1);
        }

        private int BuildTree(int k, int left, int right)
        {
            tree[k] = new SegTreeNode { Left = left, Right = right };
            if (left == right)
            {
                tree[k].Value = nums[left - 1];
                return tree[k].Value;
            }

            int mid = (left + right) >> 1;


            tree[k].Value = BuildTree(k * 2, left, mid) + BuildTree(k * 2 + 1, mid + 1, right);
            return tree[k].Value;
        }

        private int Search(int k, int left, int right)
        {
            var node = tree[k];
            if (node == null || node.Left > right || node.Right < left)
            {
                return 0;
            }

            if (node.Left >= left && node.Right <= right)
            {
                return node.Value;
            }

            return Search(k * 2, left, right) + Search(k * 2 + 1, left, right);
        }

        public void Update(int k, int i, int val)
        {
            if (tree[k].Left == tree[k].Right)
            {
                tree[k].Value = val;
                return;
            }

            if (i <= tree[k * 2].Right)
            {
                Update(k * 2, i, val);
            }
            else
            {
                Update(k * 2 + 1, i, val);
            }

            tree[k].Value = tree[k * 2].Value + tree[k * 2 + 1].Value;
        }
    }

    public class SegTreeNode
    {
        public int Left;
        public int Right;
        public int Value;
    }
}