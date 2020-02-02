namespace LeetCode.Problems
{
    /// 复写零
    /// https://leetcode-cn.com/problems/duplicate-zeros/
    public class P1089_DuplicateZeros
    {
        public void DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }

                    i++;
                }
            }
        }
    }
}