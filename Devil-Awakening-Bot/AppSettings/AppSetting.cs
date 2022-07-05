namespace Devil_Awakening_Bot.AppSettings;

public class AppSetting : JsonHelper<AppSetting>
{
    public Profiles Profile = new();

    public Options Option = new();
}