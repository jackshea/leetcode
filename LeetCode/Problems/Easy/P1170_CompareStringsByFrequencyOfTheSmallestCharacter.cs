namespace LeetCode.Problems.Easy
{
    /// 比较字符串最小字母出现频次
    /// https://leetcode-cn.com/problems/compare-strings-by-frequency-of-the-smallest-character/
    public class P1170_CompareStringsByFrequencyOfTheSmallestCharacter
    {
        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            int[] fq = new int[queries.Length];
            for (var i = 0; i < queries.Length; i++)
            {
                fq[i] = f(queries[i]);
            }

            int[] fw = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                fw[i] = f(words[i]);
            }

            int[] ans = new int[queries.Length];
            for (int i = 0; i < ans.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < fw.Length; j++)
                {
                    if (fq[i] < fw[j])
                    {
                        count++;
                    }
                }

                ans[i] = count;
            }

            return ans;
        }

        private int f(string word)
        {
            var count = new int[26];
            foreach (var c in word)
            {
                count[c - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (count[i] != 0)
                {
                    return count[i];
                }
            }

            return 0;
        }
    }
}