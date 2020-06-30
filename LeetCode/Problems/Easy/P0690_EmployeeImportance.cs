using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 员工的重要性
    /// https://leetcode-cn.com/problems/employee-importance/
    public class P0690_EmployeeImportance
    {
        public int GetImportance(IList<Employee> employees, int id)
        {
            var dic = employees.ToDictionary(p => p.id);
            int ans = 0;
            Queue<Employee> q = new Queue<Employee>();
            if (!dic.ContainsKey(id))
            {
                return 0;
            }
            q.Enqueue(dic[id]);
            while (q.Count != 0)
            {
                var top = q.Dequeue();
                ans += top.importance;
                foreach (var sub in top.subordinates)
                {
                    q.Enqueue(dic[sub]);
                }
            }

            return ans;
        }
    }

    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
}