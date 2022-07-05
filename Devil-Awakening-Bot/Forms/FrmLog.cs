namespace Devil_Awakening_Bot.Forms;

public partial class FrmLog : Form
{
    public FrmLog()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Program.FrmMain.SaveLogs();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtLogs.Clear();
    }

    private void FrmLog_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        Program.FrmMain.logsToolStripMenuItem.Checked = false;
    }
}