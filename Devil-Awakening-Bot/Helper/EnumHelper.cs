namespace Devil_Awakening_Bot.Helper;

public static class EnumHelper
{
    public static SkillType ToSkillType(this string typeName)
    {
        return typeName switch
        {
            "Major" => SkillType.Major,
            "Minor" => SkillType.Minor,
            _ => SkillType.None
        };
    }

    public static HeroSkillType ToHeroSkillType(this string typeName)
    {
        return typeName switch
        {
            "Disable," => HeroSkillType.Disable,
            "Auto" => HeroSkillType.Auto,
            "Manual" => HeroSkillType.Manual,
            _ => HeroSkillType.Disable
        };
    }
    public static Talent ToTalent(this string typeName)
    {
        return typeName switch
        {
            "Armor Proficiency" => Talent.Armor,
            "Attack Proficiency" => Talent.Attack,
            "Attack Speed Proficiency" => Talent.AttackSpeed,
            "Cri Chance Proficiency" => Talent.CriChance,
            "Cri Damage Proficiency" => Talent.CriDamage,
            "Gold Proficiency" => Talent.Gold,
            "Health Proficiency" => Talent.Health,
            "Magic Proficiency" => Talent.Magic,
            "Summon Proficiency" => Talent.Summon,
            "XP Proficiency" => Talent.XP,
            _ => Talent.None
        };
    }

    public static RuneNecromancy ToNecromancy(this string typeName)
    {
        return typeName switch
        {
            "Attack Rune" => RuneNecromancy.AttackRune,
            "Magic Rune" => RuneNecromancy.MagicRune,
            "Armor Rune" => RuneNecromancy.ArmorRune,
            "Health Rune" => RuneNecromancy.HealthRune,
            "XP Rune" => RuneNecromancy.XPRune,
            "Lift Steal Rune" => RuneNecromancy.LiftstealRune,
            "Spell Lift Steal Rune" => RuneNecromancy.SpellLiftStealRune,
            "Speed Rune" => RuneNecromancy.SpeedRune,
            "Cooldown Rune" => RuneNecromancy.CooldownRune,
            "Cri Damage Rune" => RuneNecromancy.CriDamageRune,
            "Final DamageRune" => RuneNecromancy.FinalDamageRune,
            "Damage Reduction Rune" => RuneNecromancy.DamageReductionRune,
            "Gold Rune" => RuneNecromancy.GoldRune,
            "Necro Rune" => RuneNecromancy.NecroRune,
            "Lucky Rune" => RuneNecromancy.LuckyRune,
            _ => RuneNecromancy.None
        };
    }

    public static AwakingSpell ToSpell(this string typeName)
    {
        return typeName switch
        {
            "Broken Heart" => AwakingSpell.BrokenHeart,
            "Legacy of Thunder" => AwakingSpell.LegacyOfThunder,
            "Flame Remnant" => AwakingSpell.FlameRemnant,
            "Guardian Boundary" => AwakingSpell.GuardianBoundary,
            "Disaster Of The Sleepy" => AwakingSpell.DisasterOfTheSleepy,
            "Unlimited Mana" => AwakingSpell.UnlimitedMana,
            "Recovery" => AwakingSpell.Recovery,
            "None" => AwakingSpell.None,
            _ => AwakingSpell.None,
        };
    }
}