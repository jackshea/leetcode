namespace LeetCode.Problems.Easy
{
    /// 翻转图像
    /// https://leetcode-cn.com/problems/flipping-an-image/
    public class P0832_FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            foreach (var row in A)
            {
                int left = 0;
                int right = row.Length - 1;
                while (left < right)
                {
                    int temp = Invert(row[left]);
                    row[left] = Invert(row[right]);
                    row[right] = temp;
                    left++;
                    right--;
                }

                if (left == right)
                {
                    row[left] = Invert(row[left]);
                }
            }

            return A;
        }

        private int Invert(int a)
        {
            return a ^ 1;
        }
    }
}