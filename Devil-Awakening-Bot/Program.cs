namespace Devil_Awakening_Bot;

internal static class Program
{
    public static FrmMain FrmMain = null!;

    [STAThread]
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        PublicClass.AppSetting = AppSetting.Load();
        Application.Run(args.Length == 0 ? FrmMain = new FrmMain("") : FrmMain = new FrmMain(args[0]));
    }
}