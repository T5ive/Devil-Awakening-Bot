namespace Devil_Awakening_Bot.Devil;

public class Hero
{
    public string Name { get; set; } = null!;
    public HeroSkillType SkillQ { get; set; }
    public HeroSkillType SkillR { get; set; }

    public Hero()
    {

    }
    public Hero(string name, HeroSkillType skillQ, HeroSkillType skillR)
    {
        Name = name;
        SkillQ = skillQ;
        SkillR = skillR;
    }
}