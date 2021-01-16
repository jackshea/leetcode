namespace LeetCode.Problems.Easy
{
    /// 无法吃午餐的学生数量
    /// https://leetcode-cn.com/problems/number-of-students-unable-to-eat-lunch/
    public class P1700_NumberOfStudentsUnableToEatLunch
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int stu0 = 0, stu1 = 0;
            foreach (var student in students)
            {
                if (student == 0)
                {
                    stu0++;
                }
                else
                {
                    stu1++;
                }
            }

            foreach (var sandwich in sandwiches)
            {
                if (sandwich == 0)
                {
                    if (stu0 == 0)
                    {
                        break;
                    }

                    stu0--;
                }
                else
                {
                    if (stu1 == 0)
                    {
                        break;
                    }

                    stu1--;
                }
            }

            return stu0 + stu1;
        }
    }
}