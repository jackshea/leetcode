namespace LeetCode.Problems.Easy
{
    /// 柠檬水找零
    /// https://leetcode-cn.com/problems/lemonade-change/
    public class P0860_LemonadeChange
    {
        public bool LemonadeChange(int[] bills)
        {
            int dollar5 = 0;
            int dollar10 = 0;
            foreach (var bill in bills)
            {
                switch (bill)
                {
                    case 5:
                        dollar5++;
                        break;
                    case 10:
                        if (dollar5 == 0)
                        {
                            return false;
                        }

                        dollar5--;
                        dollar10++;
                        break;
                    case 20:
                        if (dollar10 > 0 && dollar5 > 0)
                        {
                            dollar10--;
                            dollar5--;
                        }
                        else if (dollar5 >= 3)
                        {
                            dollar5 -= 3;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                }
            }

            return true;
        }
    }
}