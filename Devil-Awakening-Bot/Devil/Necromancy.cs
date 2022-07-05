namespace Devil_Awakening_Bot.Devil;

public class Necromancy
{
    public RuneNecromancy Rune { get; set; }

    public int Time { get; set; }

    public string TimeResult { get; set; }

    public Necromancy()
    {
        Rune = RuneNecromancy.None;
        Time = 0;
        TimeResult = Time.SecToMin() + " นาที";
    }

    public Necromancy(RuneNecromancy rune, int time, string result)
    {
        Rune = rune;
        Time = time;
        TimeResult = result;
    }
}