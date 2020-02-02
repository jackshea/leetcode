namespace LeetCode.Problems
{
    /// 旋转数字
    /// https://leetcode-cn.com/problems/rotated-digits/
    public class P0788_RotatedDigits
    {
        public int RotatedDigits(int N)
        {
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                if (rotateNumber(i) != -1 && rotateNumber(i) != i)
                {
                    count++;
                }
            }

            return count;
        }

        private int rotateNumber(int num)
        {
            var charArray = num.ToString().ToCharArray();
            for (var i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case '0': break;
                    case '1': break;
                    case '2':
                        charArray[i] = '5';
                        break;
                    case '3': return -1;
                    case '4': return -1;
                    case '5':
                        charArray[i] = '2';
                        break;
                    case '6':
                        charArray[i] = '9';
                        break;
                    case '7': return -1;
                    case '8': break;
                    case '9':
                        charArray[i] = '6';
                        break;
                }
            }

            return int.Parse(new string(charArray));
        }
    }
}