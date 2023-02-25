namespace LeetCode.Problems.Easy;

/// 学生出勤记录 I
/// https://leetcode-cn.com/problems/student-attendance-record-i/
public class P0551_StudentAttendanceRecordI
{
    public bool CheckRecord(string s)
    {
        var a = 0;
        var contiL = 0;

        foreach (var c in s)
        {
            if (c == 'A')
            {
                a++;
                if (a > 1) return false;
            }

            if (c == 'L')
            {
                contiL++;
                if (contiL > 2) return false;
            }
            else
            {
                contiL = 0;
            }
        }

        return true;
    }
}