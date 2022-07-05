namespace Devil_Awakening_Bot.Utils;

public static class Msg
{
    private const string Caption = "Devil Awakening Bot";

    public static void Error(string text)
    {
        MessageBox.Show(text, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void Warning(string text)
    {
        MessageBox.Show(text, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void Info(string text)
    {
        MessageBox.Show(text, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void Show(string text, MessageBoxIcon icon = MessageBoxIcon.None)
    {
        MessageBox.Show(text, Caption, MessageBoxButtons.OK, icon);
    }

    public static bool OkCancel(string text)
    {
        return MessageBox.Show(text, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
    }

    public static DialogResult YesNoCancel(string text)
    {
        return MessageBox.Show(text, Caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
    }
}