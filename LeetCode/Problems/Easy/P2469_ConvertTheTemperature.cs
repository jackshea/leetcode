namespace LeetCode.Problems.Easy;

/// 温度转换
/// https://leetcode.cn/problems/convert-the-temperature/
public class P2469_ConvertTheTemperature
{
    public double[] ConvertTemperature(double celsius)
    {
        return new[] {celsius + 273.15, celsius * 1.80 + 32.00};
    }
}