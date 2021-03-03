namespace LeetCode.Problems.Medium
{
    /// 下一个更大元素 III
    /// https://leetcode-cn.com/problems/next-greater-element-iii/
    public class P0556_NextGreaterElementIII
    {
        public int NextGreaterElement(int n)
        {
            var charArray = n.ToString().ToCharArray();
            int findIdx = charArray.Length - 2;
            while (findIdx >= 0 && charArray[findIdx] >= charArray[findIdx + 1])
            {
                findIdx--;
            }

            if (findIdx < 0)
            {
                return -1;
            }

            int justGt = charArray.Length - 1;
            while (justGt >= 0 && charArray[justGt] <= charArray[findIdx])
            {
                justGt--;
            }
            Swap(charArray, findIdx, justGt);
            Reverse(charArray, findIdx + 1, charArray.Length - 1);

            if (int.TryParse(new string(charArray), out var ans))
            {
                return ans;
            }

            return -1;
        }

        private void Swap(char[] charArray, int i, int j)
        {
            char c = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = c;
        }

        private void Reverse(char[] charArray, int i, int j)
        {
            while (i < j)
            {
                Swap(charArray, i, j);
                i++;
                j--;
            }
        }
    }
}