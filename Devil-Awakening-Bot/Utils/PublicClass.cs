namespace Devil_Awakening_Bot.Utils;

public static class PublicClass
{
    public static AppSetting AppSetting { get; set; } = new();
    public static readonly string AppPath = AppDomain.CurrentDomain.BaseDirectory;
    public static readonly string CapturePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dota2", "Capture");
}