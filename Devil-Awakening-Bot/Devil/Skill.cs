namespace Devil_Awakening_Bot.Devil;

public class Skill
{
    public string Name { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public SkillType Type { get; set; }

    [JsonIgnore]
    public bool IsActive { get; set; }

    [JsonIgnore]
    public bool IsMain { get; set; }

    public Skill()
    {
        Name = "";
        Type = SkillType.None;
        IsActive = false;
        IsMain = false;
    }

    public Skill(string name, SkillType type)
    {
        Name = name;
        Type = type;
    }
}