namespace Devil_Awakening_Bot.Helper;

public static class DevilHelper
{
    public static Point GetPoint(this RuneNecromancy runeNecromancy)
    {
        return runeNecromancy switch
        {
            RuneNecromancy.AttackRune => new Point(1630, 500),
            RuneNecromancy.MagicRune => new Point(1690, 500),
            RuneNecromancy.ArmorRune => new Point(1750, 500),
            RuneNecromancy.HealthRune => new Point(1810, 500),
            RuneNecromancy.XPRune => new Point(1870, 500),
            RuneNecromancy.LiftstealRune => new Point(1630, 560),
            RuneNecromancy.SpellLiftStealRune => new Point(1690, 560),
            RuneNecromancy.SpeedRune => new Point(1750, 560),
            RuneNecromancy.CooldownRune => new Point(1810, 560),
            RuneNecromancy.CriDamageRune => new Point(1870, 560),
            RuneNecromancy.FinalDamageRune => new Point(1630, 615),
            RuneNecromancy.DamageReductionRune => new Point(1690, 615),
            RuneNecromancy.GoldRune => new Point(1750, 615),
            RuneNecromancy.NecroRune => new Point(1810, 615),
            RuneNecromancy.LuckyRune => new Point(1870, 615),
            _ => new Point(500, 500)
        };
    }
}