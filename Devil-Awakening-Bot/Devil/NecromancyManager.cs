namespace Devil_Awakening_Bot.Devil;

public static class NecromancyManager
{
    public static RuneNecromancy GetTime(this int timeMatch)
    {
        var totalTime = new List<int>();

        for (int i = 0; i < PublicClass.AppSetting.Profile.Necromancy.Count; i++)
        {
            if (i == 0)
            {
                totalTime.Add(PublicClass.AppSetting.Profile.Necromancy[i].Time);
            }
            else
            {
                totalTime.Add(PublicClass.AppSetting.Profile.Necromancy[i].Time + totalTime[i - 1]);
            }
        }

        for (var i = 0; i < totalTime.Count; i++)
        {
            if (timeMatch <= totalTime[i])
            {
                return PublicClass.AppSetting.Profile.Necromancy[i].Rune;
            }

            if (timeMatch >= totalTime[^1])
            {
                return PublicClass.AppSetting.Profile.Necromancy[^1].Rune;
            }
        }

        return RuneNecromancy.None;
    }
}