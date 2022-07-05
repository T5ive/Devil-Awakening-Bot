namespace Devil_Awakening_Bot.Forms;

public partial class FrmOption : Form
{
    public FrmOption()
    {
        InitializeComponent();
    }

    private void FrmOption_Load(object sender, EventArgs e)
    {
        LoadLogs();
    }

    private void LoadLogs()
    {
        chkAutoSave.Checked = PublicClass.AppSetting.Option.Log.AutoSaveLogs;
        chkSteamDota.Checked = PublicClass.AppSetting.Option.Log.SteamDotaLog;
        chkUpdate.Checked = PublicClass.AppSetting.Option.Log.UpdateLog;
        chkBot.Checked = PublicClass.AppSetting.Option.Log.BotLog;
        chkGeneral.Checked = PublicClass.AppSetting.Option.Log.General;
        chkMain.Checked = PublicClass.AppSetting.Option.Log.MainLog;
        chkPrepare.Checked = PublicClass.AppSetting.Option.Log.PrepareLog;
        chkSetup.Checked = PublicClass.AppSetting.Option.Log.SetupLog;
        chkleave.Checked = PublicClass.AppSetting.Option.Log.LeaveLog;
        chkRoundEnd.Checked = PublicClass.AppSetting.Option.Log.RoundLog;
        chkSkill.Checked = PublicClass.AppSetting.Option.Log.SkillLog;
        chkTreasures.Checked = PublicClass.AppSetting.Option.Log.TreasuresLog;
        chkInGame.Checked = PublicClass.AppSetting.Option.Log.InGameLog;
        chkBoss.Checked = PublicClass.AppSetting.Option.Log.BossLog;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        SaveOptions();
    }

    private void SaveOptions()
    {
        try
        {
            if (Msg.OkCancel("Save Settings.\n\n" +
                             "Click \"OK\" to confirm.\n\n" +
                             "Click \"Cancel\" to cancel."))
            {
                PublicClass.AppSetting.Option.Log.AutoSaveLogs = chkAutoSave.Checked;
                PublicClass.AppSetting.Option.Log.SteamDotaLog = chkSteamDota.Checked;
                PublicClass.AppSetting.Option.Log.UpdateLog = chkUpdate.Checked;
                PublicClass.AppSetting.Option.Log.BotLog = chkBot.Checked;
                PublicClass.AppSetting.Option.Log.General = chkGeneral.Checked;
                PublicClass.AppSetting.Option.Log.MainLog = chkMain.Checked;
                PublicClass.AppSetting.Option.Log.PrepareLog = chkPrepare.Checked;
                PublicClass.AppSetting.Option.Log.SetupLog = chkSetup.Checked;
                PublicClass.AppSetting.Option.Log.LeaveLog = chkleave.Checked;
                PublicClass.AppSetting.Option.Log.RoundLog = chkRoundEnd.Checked;
                PublicClass.AppSetting.Option.Log.SkillLog = chkSkill.Checked;
                PublicClass.AppSetting.Option.Log.TreasuresLog = chkTreasures.Checked;
                PublicClass.AppSetting.Option.Log.InGameLog = chkInGame.Checked;
                PublicClass.AppSetting.Option.Log.BossLog = chkBoss.Checked;
                PublicClass.AppSetting.Save();
                Close();
            }
        }
        catch
        {
            //
        }
    }
}