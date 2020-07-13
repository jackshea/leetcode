namespace LeetCode.Problems.Easy
{
    /// 在既定时间做作业的学生人数
    /// https://leetcode-cn.com/problems/number-of-students-doing-homework-at-a-given-time/
    public class P1450_NumberOfStudentsDoingHomeworkAtAGivenTime
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int ans = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (queryTime >= startTime[i] && queryTime <= endTime[i])
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}