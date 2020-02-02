namespace LeetCode.Problems
{
    /// IP 地址无效化
    /// https://leetcode-cn.com/problems/defanging-an-ip-address/
    public class P1108_DefangingAnIpAddress
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}