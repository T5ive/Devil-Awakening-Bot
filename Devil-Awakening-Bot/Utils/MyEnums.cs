namespace Devil_Awakening_Bot.Utils;

public static class MyEnums
{
    public enum Episode
    {
        EP1,
        EP2
    }

    public enum Level
    {
        N1,
        N2,
        N3,
        N4,
        N5,
        N6,
        N7,
        N8,
        N9,
        N10, // Endless EP1
        N11,
        N12,
        N13,
        N14,
        N15,
        N16,
        N17,
        N18,
        N19,
        EndLess
    }

    public enum BotStep
    {
        Arcade = 0,
        Library = 1,
        Devil = 2,
        Lobby = 3,
        Setting = 4,
        Start = 5,
        Accept = 6,

        Level = 7,
        SelectPath = 8,
        Hero = 9,
        Select = 10,
        Apply = 11,
        Ready = 12,

        Talent = 13,
        Artifact = 14,
        Setup = 15,

        InGame = 16,
        Boss = 17,
        BossKilled = 18,

        Abyss = 19,
        AbyssKilled = 20,

        End = 21,

        Disconnect = 49,
        Leave = 50,
        Leave2 = 51,
        RoundUp = 52,

        ForceExit = 101,

        Wait = 5555,

        ExitDota = 99999,
        StartDota = 9999999
    }

    public enum MoveType
    {
        MoveUp = 0,
        MoveDown = 1
    }

    public enum SkillType
    {
        Major,
        Minor,
        None
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum HeroSkillType
    {
        Disable,
        Auto,
        Manual
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuneNecromancy
    {
        AttackRune,
        MagicRune,
        ArmorRune,
        HealthRune,
        XPRune,
        LiftstealRune,
        SpellLiftStealRune,
        SpeedRune,
        CooldownRune,
        CriDamageRune,
        FinalDamageRune,
        DamageReductionRune,
        GoldRune,
        NecroRune,
        LuckyRune,
        None
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Artifact
    {
        SacredInfernoBlade,
        ElementalSphere,
        BloodBurning,
        RockBody,
        OrdinaryPunch,
        VoidWalk,
        IronBloodSilverWolf
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AwakingSpell
    {
        BrokenHeart,
        LegacyOfThunder,
        FlameRemnant,
        GuardianBoundary,
        DisasterOfTheSleepy,
        UnlimitedMana,
        Recovery,
        None
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Talent
    {
        Armor,
        Attack,
        AttackSpeed,
        CriChance,
        CriDamage,
        Gold,
        Health,
        Magic,
        Summon,
        XP,
        None
    }

    public enum LogType
    {
        Bot,
        Info,
        Error,
        App
    }

    public enum AddDataType
    {
        Normal,
        Hero,
        Skill,
        Necro
    }
}