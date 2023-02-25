namespace LeetCode.Problems.Medium;

/// 验证IP地址
/// https://leetcode-cn.com/problems/validate-ip-address/
public class P0468_ValidateIpAddress
{
    public string ValidIPAddress(string IP)
    {
        foreach (var c in IP)
        {
            if (c == '.')
            {
                if (isIPV4(IP)) return "IPv4";

                break;
            }

            if (c == ':')
            {
                if (isIPV6(IP)) return "IPv6";
                break;
            }
        }

        return "Neither";
    }

    private bool isIPV4(string IP)
    {
        var ipNums = IP.Split('.');
        if (ipNums.Length != 4) return false;

        foreach (var ipNum in ipNums)
        {
            if (ipNum != "0" && ipNum.StartsWith("0")) return false;

            if (int.TryParse(ipNum, out var num))
            {
                if (num < 0 || num > 255) return false;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    private bool isIPV6(string IP)
    {
        var ipNums = IP.Split(':');
        if (ipNums.Length != 8) return false;

        foreach (var ipNum in ipNums)
        {
            if (ipNum.Length > 4 || ipNum.Length == 0) return false;

            foreach (var c in ipNum)
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))
                    continue;
                else
                    return false;
        }

        return true;
    }
}