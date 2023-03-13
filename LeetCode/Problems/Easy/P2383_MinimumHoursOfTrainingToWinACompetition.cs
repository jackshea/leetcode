namespace LeetCode.Problems.Easy;

/// 赢得比赛需要的最少训练时长
/// https://leetcode.cn/problems/minimum-hours-of-training-to-win-a-competition/
public class P2383_MinimumHoursOfTrainingToWinACompetition
{
    public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
    {
        int sumEnergy = 0;
        // 需要补充的经验
        int needExperience = 0;
        int currentExperience = initialExperience;
        for (int i = 0; i < energy.Length; i++)
        {
            sumEnergy += energy[i];

            if (currentExperience <= experience[i])
            {
                needExperience += experience[i] - currentExperience + 1;
                currentExperience = experience[i] + 1;
            }

            currentExperience += experience[i];
        }

        int needEnergy = initialEnergy > sumEnergy ? 0 : sumEnergy - initialEnergy + 1;
        return needEnergy + needExperience;
    }
}