namespace Devil_Awakening_Bot.Devil;

public static class HeroManager
{
    public static Hero GetHero(this string name)
    {
        foreach (var hero in PublicClass.AppSetting.Profile.Heroes.Where(hero => hero.Name == name))
        {
            return hero;
        }

        return new Hero();
    }
}