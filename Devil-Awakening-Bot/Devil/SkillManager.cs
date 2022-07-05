namespace Devil_Awakening_Bot.Devil;

public static class SkillManager
{
    public static List<Skill> Skills = new();

    public static List<string> PassiveSkill = new()
    {
        "Boar",
        "Counter Helix",
        "Deadly Frenzy",
        "Extreme Cold Ice Break",
        "Guriken",
        "Lacerated Wounds",
        "Lightning Strike",
        "Sacred Light",
        "Thunder Clap",
        "Thunderbird"
    };

    public static void AddSkill(DataGridView dataList, List<Skill> skills)
    {
        skills.Clear();
        for (var rows = 0; rows < dataList.Rows.Count; rows++)
        {
            var name = dataList.Rows[rows].Cells[0].Value.ToString();
            var type = dataList.Rows[rows].Cells[1].Value.ToString();
            AddSkill(name!, type!.ToSkillType(), skills);
        }
    }

    public static void AddSkill(string name, SkillType type, List<Skill> skills)
    {
        skills.Add(new Skill(name, type));
    }

    public static SkillType GetSkillType(this string name, List<Skill> listSkills)
    {
        foreach (var skill in listSkills.Where(skill => skill.Name == name))
        {
            return skill.Type;
        }

        return SkillType.None;
    }
}