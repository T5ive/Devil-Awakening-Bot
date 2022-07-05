using System.Security.Policy;

namespace Devil_Awakening_Bot.Helper;

public static class StringHelper
{
    public static string ToStr(this BotStep step)
    {
        return step switch
        {
            BotStep.Arcade => "อาร์เคต",
            BotStep.Library => "คลัง",
            BotStep.Devil => "Devil",
            BotStep.Lobby => "สร้าง",
            BotStep.Setting => "ตั้งค่า",
            BotStep.Start => "เริ่มเกม",
            BotStep.Accept => "ยอมรับ",
            BotStep.Level => "ระดับ",
            BotStep.SelectPath => "เตรียมตัว",
            BotStep.Hero => "หาฮีโร่",
            BotStep.Select => "เลือกฮีโร่",
            BotStep.Apply => "ยืนยันชนิด",
            BotStep.Ready => "พร้อม",
            BotStep.Talent => "Talent",
            BotStep.Artifact => "Artifact",
            BotStep.Setup => "เริ่มต้น",
            BotStep.InGame => "ในเกม",
            BotStep.Boss => "พบบอส",
            BotStep.BossKilled => "บอสตาย",
            BotStep.Abyss => "บอสนรก",
            BotStep.AbyssKilled => "บอสนรกตาย",
            BotStep.End => "จบเกม",
            BotStep.Disconnect => "ตัดการเชื่อมต่อ",
            BotStep.Leave => "ออกอาร์เคต",
            BotStep.Leave2 => "ยืนยันออก",
            BotStep.RoundUp => "จบรอบ",
            BotStep.ForceExit => "บังคับออก",
            BotStep.Wait => "รอ",
            BotStep.ExitDota => "ออก Dota2",
            BotStep.StartDota => "เริ่ม Dota2",
            _ => ""
        };
    }

    public static string ToStr(this Artifact type)
    {
        return type switch
        {
            Artifact.SacredInfernoBlade => "Sacred Inferno Blade",
            Artifact.ElementalSphere => "Elemental Sphere",
            Artifact.BloodBurning => "Blood Burning",
            Artifact.RockBody => "Rock Body",
            Artifact.OrdinaryPunch => "Ordinary Punch",
            Artifact.VoidWalk => "Void Walk",
            Artifact.IronBloodSilverWolf => "Iron Blood Silver Wolf",
            _ => ""
        };
    }

    public static string ToStr(this Talent type)
    {
        return type switch
        {
            Talent.Armor => "Armor Proficiency",
            Talent.Attack => "Attack Proficiency",
            Talent.AttackSpeed => "Attack Speed Proficiency",
            Talent.CriChance => "Cri Chance Proficiency",
            Talent.CriDamage => "Cri Damage Proficiency",
            Talent.Gold => "Gold Proficiency",
            Talent.Health => "Health Proficiency",
            Talent.Magic => "Magic Proficiency",
            Talent.Summon => "Summon Proficiency",
            Talent.XP => "XP Proficiency",
            _ => ""
        };
    }

    public static string ToStr(this AwakingSpell type)
    {
        return type switch
        {
            AwakingSpell.BrokenHeart => "Broken Heart",
            AwakingSpell.LegacyOfThunder => "Legacy of Thunder",
            AwakingSpell.FlameRemnant => "Flame Remnant",
            AwakingSpell.GuardianBoundary => "Guardian Boundary",
            AwakingSpell.DisasterOfTheSleepy => "Disaster Of The Sleepy",
            AwakingSpell.UnlimitedMana => "Unlimited Mana",
            AwakingSpell.Recovery => "Recovery",
            AwakingSpell.None => "None",
            _ => ""
        };
    }

    public static string ToStr(this RuneNecromancy type)
    {
        return type switch
        {
            RuneNecromancy.AttackRune => "Attack Rune",
            RuneNecromancy.MagicRune => "Magic Rune",
            RuneNecromancy.ArmorRune => "Armor Rune",
            RuneNecromancy.HealthRune => "Health Rune",
            RuneNecromancy.XPRune => "XP Rune",
            RuneNecromancy.LiftstealRune => "Lift Steal Rune",
            RuneNecromancy.SpellLiftStealRune => "Spell Lift Steal Rune",
            RuneNecromancy.SpeedRune => "Speed Rune",
            RuneNecromancy.CooldownRune => "Cooldown Rune",
            RuneNecromancy.CriDamageRune => "Cri Damage Rune",
            RuneNecromancy.FinalDamageRune => "Final DamageRune",
            RuneNecromancy.DamageReductionRune => "Damage Reduction Rune",
            RuneNecromancy.GoldRune => "Gold Rune",
            RuneNecromancy.NecroRune => "Necro Rune",
            RuneNecromancy.LuckyRune => "Lucky Rune",
            _ => ""
        };
    }

    public static string ToStr(this HeroSkillType type)
    {
        return type switch
        {
            HeroSkillType.Disable => "Disable",
            HeroSkillType.Auto => "Auto",
            HeroSkillType.Manual => "Manual",
            _ => "Disable"
        };
    }

    public static string ToFileName(this string fullPath)
    {
        return Path.GetFileNameWithoutExtension(fullPath);
    }
}