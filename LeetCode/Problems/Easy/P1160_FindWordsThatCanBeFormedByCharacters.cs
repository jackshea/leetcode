namespace LeetCode.Problems.Easy
{
    /// 拼写单词
    /// https://leetcode-cn.com/problems/find-words-that-can-be-formed-by-characters/
    public class P1160_FindWordsThatCanBeFormedByCharacters
    {
        public int CountCharacters(string[] words, string chars)
        {
            var charsJudge = new int[26];
            foreach (var c in chars)
            {
                charsJudge[c - 'a']++;
            }

            int ans = 0;
            var wordJudge = new int[26];
            foreach (var word in words)
            {
                for (int i = 0; i < wordJudge.Length; i++)
                {
                    wordJudge[i] = 0;
                }

                foreach (var c in word)
                {
                    wordJudge[c - 'a']++;
                }

                bool isOK = true;
                for (int i = 0; i < 26; i++)
                {
                    if (wordJudge[i] > charsJudge[i])
                    {
                        isOK = false;
                        break;
                    }
                }

                if (isOK)
                {
                    ans += word.Length;
                }
            }

            return ans;
        }
    }
}