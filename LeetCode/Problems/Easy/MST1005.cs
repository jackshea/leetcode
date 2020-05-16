namespace LeetCode.Problems.Easy
{
    /// 稀疏数组搜索
    /// https://leetcode-cn.com/problems/sparse-array-search-lcci/
    public class MST1005
    {
        public int FindString(string[] words, string s)
        {
            int left = 0, right = words.Length - 1;
            while (left < right)
            {
                while (left <= right && words[left] == "")
                {
                    left++;
                }

                while (left <= right && words[right] == "")
                {
                    right--;
                }

                int mid = left + (right - left) / 2;
                while (words[mid] == "")
                {
                    mid--;
                }

                if (words[mid] == s)
                {
                    return mid;
                }
                if (string.Compare(s, words[mid]) < 0)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if (words[left] == s)
            {
                return left;
            }
            return -1;
        }
    }
}