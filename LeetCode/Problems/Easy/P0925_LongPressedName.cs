namespace LeetCode.Problems
{
    /// 长按键入
    /// https://leetcode-cn.com/problems/long-pressed-name/
    public class P0925_LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int nameIndex = 0;
            for (var i = 0; i < typed.Length; i++)
            {
                if (nameIndex < name.Length && name[nameIndex] == typed[i])
                {
                    nameIndex++;
                }
                else if (i > 0 && typed[i] == typed[i - 1])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return nameIndex == name.Length;
        }
    }
}