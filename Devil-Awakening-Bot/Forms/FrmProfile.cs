namespace Devil_Awakening_Bot.Forms;

public partial class FrmProfile : Form
{
    #region Variable

    private static string? _steamIniDir;

    private static string? SteamIniDir
    {
        get => _steamIniDir;
        set
        {
            _steamIniDir = value;
            Settings.Default.Steam = value;
            Settings.Default.Save();
        }
    }

    #endregion Variable

    public FrmProfile()
    {
        InitializeComponent();
    }

    #region Load

    private void FrmProfile_Load(object sender, EventArgs e)
    {
        LoadSettings();
        LoadAppSetting();
        UpdateHero();
        UpdateTalent();
        UpdateTreasure();
        UpdateSkill();
        UpdateNecromancy();
    }

    private static void LoadSettings()
    {
        SteamIniDir = Settings.Default.Steam;
    }

    private void LoadAppSetting()
    {
        txtSteam.Text = PublicClass.AppSetting.Profile.SteamPath;

        numRound.Value = PublicClass.AppSetting.Profile.LimitRound;
        numPick.Value = PublicClass.AppSetting.Profile.PickTime;
        numNecro.Value = PublicClass.AppSetting.Profile.NecroTime;
        numLeave.Value = PublicClass.AppSetting.Profile.LeaveTime;

        cbN.SelectedIndex = (int)PublicClass.AppSetting.Profile.Level;
        chkAbyss.Checked = PublicClass.AppSetting.Profile.Abyss;
        chkTicket.Checked = PublicClass.AppSetting.Profile.Ticket;

        if (PublicClass.AppSetting.Profile.Artifacts.Count >= 1)
        {
            cbArtifact.SelectedIndex = (int)PublicClass.AppSetting.Profile.Artifacts[0];
        }

        if (PublicClass.AppSetting.Profile.Artifacts.Count is 2)
        {
            cbArtifact2.SelectedIndex = (int)PublicClass.AppSetting.Profile.Artifacts[1];
        }

        chkVip.Checked = PublicClass.AppSetting.Profile.VIP;
        chkRefresh.Checked = PublicClass.AppSetting.Profile.Refresh;

        ChkGift.Checked = PublicClass.AppSetting.Profile.Gift;

        SkillManager.Skills = PublicClass.AppSetting.Profile.Skills;

        cbAwakingSpell.SelectedIndex = (int)PublicClass.AppSetting.Profile.AwakingSpell;
    }

    #endregion Load

    #region Save

    private void btnSave_Click(object sender, EventArgs e)
    {
        SaveAppSettings();
    }

    private void SaveAppSettings()
    {
        try
        {
            if (Msg.OkCancel("Save Settings.\n\n" +
                             "Click \"OK\" to confirm.\n\n" +
                             "Click \"Cancel\" to cancel."))
            {
                PublicClass.AppSetting.Profile.SteamPath = txtSteam.Text;

                PublicClass.AppSetting.Profile.LimitRound = (int)numRound.Value;
                PublicClass.AppSetting.Profile.PickTime = (int)numPick.Value;
                PublicClass.AppSetting.Profile.NecroTime = (int)numNecro.Value;
                PublicClass.AppSetting.Profile.LeaveTime = (int)numLeave.Value;
                PublicClass.AppSetting.Profile.Level = (Level)cbN.SelectedIndex;
                PublicClass.AppSetting.Profile.Episode = cbN.SelectedIndex < 10 ? Episode.EP1 : Episode.EP2;
                PublicClass.AppSetting.Profile.Abyss = chkAbyss.Checked;
                PublicClass.AppSetting.Profile.Artifacts = GetArtifacts();
                PublicClass.AppSetting.Profile.Ticket = chkTicket.Checked;

                PublicClass.AppSetting.Profile.VIP = chkVip.Checked;
                PublicClass.AppSetting.Profile.Refresh = chkRefresh.Checked;

                PublicClass.AppSetting.Profile.Heroes = GetHeroes();
                PublicClass.AppSetting.Profile.Talents = GetTalent();
                PublicClass.AppSetting.Profile.Treasures = GetTreasure();
                PublicClass.AppSetting.Profile.Gift = ChkGift.Checked;

                SkillManager.AddSkill(dataSkill, SkillManager.Skills);
                PublicClass.AppSetting.Profile.Skills = SkillManager.Skills;
                PublicClass.AppSetting.Profile.AwakingSpell = (AwakingSpell)cbAwakingSpell.SelectedIndex;

                PublicClass.AppSetting.Profile.Necromancy = GetNecromancy();
                PublicClass.AppSetting.Save();
                Close();
            }
        }
        catch
        {
            //
        }
    }

    #endregion Save

    #region General

    private void btnBrowseSteam_Click(object sender, EventArgs e)
    {
        var openFile = new OpenFileDialog
        {
            Filter = "Steam|steam.exe|All files(*.*)|*.*",
            Title = Text
        };

        if (SteamIniDir != null)
        {
            openFile.InitialDirectory = SteamIniDir;
        }

        if (openFile.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var filePath = openFile.FileName;
                SteamIniDir = Path.GetDirectoryName(filePath);
                txtSteam.Text = filePath;
            }
            catch (Exception ex)
            {
                Program.FrmMain.WriteOutput(ex.Message, LogType.Error);
            }
        }
    }


    #region Num Change

    private void numPick_ValueChanged(object sender, EventArgs e)
    {
        lbPick.Text = $"{((int)numPick.Value).SecToMin()} นาที";
    }

    private void numLeave_ValueChanged(object sender, EventArgs e)
    {
        lbLeave.Text = $"{((int)numLeave.Value).SecToMin()} นาที";
    }

    private void numNecro_ValueChanged(object sender, EventArgs e)
    {
        lbPick.Text = $"{((int)numPick.Value).SecToMin()} นาที";
    }

    #endregion Num Change

    private List<Artifact> GetArtifacts()
    {
        var result = new List<Artifact>
        {
            (Artifact)cbArtifact.SelectedIndex,
            (Artifact)cbArtifact2.SelectedIndex,
        };
        return result;
    }

    #endregion General

    #region Hero

    private void UpdateHero()
    {
        foreach (var t in PublicClass.AppSetting.Profile.Heroes)
        {
            dataHero.Rows.Add(t.Name, t.SkillQ.ToStr(), t.SkillR.ToStr());

            for (var j = 0; j < cbHeroes.Items.Count; j++)
            {
                if (cbHeroes.Items[j].ToString() != t.Name) continue;
                cbHeroes.Items.RemoveAt(j);
                break;
            }
        }

        if (cbHeroes.Items.Count > 0)
            cbHeroes.SelectedIndex = 0;
    }
    private List<Hero> GetHeroes()
    {
        var result = new List<Hero>();
        for (var i = 0; i < dataHero.Rows.Count; i++)
        {
            var name = dataHero.Rows[i].Cells[0].Value.ToString()!;
            var skillQ = dataHero.Rows[i].Cells[1].Value.ToString()!.ToHeroSkillType();
            var skillR = dataHero.Rows[i].Cells[2].Value.ToString()!.ToHeroSkillType();
            result.Add(new Hero(name, skillQ, skillR));
        }
        return result;
    }
    private void btnAddHero_Click(object sender, EventArgs e)
    {
        AddData(dataHero, cbHeroes, AddDataType.Hero);
    }

    private void btnRemoveHero_Click(object sender, EventArgs e)
    {
        RemoveRows(dataHero);
    }

    private void dataHero_SelectionChanged(object sender, EventArgs e)
    {
        EnableButton(dataHero, btnRemoveHero);
    }

    private void dataHero_MouseDown(object sender, MouseEventArgs e)
    {
        DataMouseDown(dataHero, e);
    }

    private void dataHero_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            RemoveRows(dataHero);
        }
    }

    #endregion Hero

    #region Talent

    private void UpdateTalent()
    {
        foreach (var t in PublicClass.AppSetting.Profile.Talents)
        {
            dataTalent.Rows.Add(t.ToStr());

            for (var j = 0; j < cbTalents.Items.Count; j++)
            {
                if (cbTalents.Items[j].ToString() != t.ToStr()) continue;
                cbTalents.Items.RemoveAt(j);
                break;
            }
        }

        if (cbTalents.Items.Count > 0)
            cbTalents.SelectedIndex = 0;
    }

    private List<Talent> GetTalent()
    {
        var result = new List<Talent>();
        for (var i = 0; i < dataTalent.Rows.Count; i++)
        {
            var name = dataTalent.Rows[i].Cells[0].Value.ToString()!.ToTalent();
            result.Add(name);
        }

        return result;
    }

    private void btnAddTalent_Click(object sender, EventArgs e)
    {
        AddData(dataTalent, cbTalents, AddDataType.Normal);
    }

    private void btnRemoveTalent_Click(object sender, EventArgs e)
    {
        RemoveRows(dataTalent);
    }

    private void dataTalent_SelectionChanged(object sender, EventArgs e)
    {
        EnableButton(dataTalent, btnRemoveTalent);
    }

    private void dataTalent_MouseDown(object sender, MouseEventArgs e)
    {
        DataMouseDown(dataTalent, e);
    }

    private void dataTalent_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            RemoveRows(dataTalent);
        }
    }

    #endregion Talent

    #region Treasures

    private void UpdateTreasure()
    {
        foreach (var t in PublicClass.AppSetting.Profile.Treasures)
        {
            dataTreasures.Rows.Add(t);

            for (var j = 0; j < cbTalents.Items.Count; j++)
            {
                if (cbTreasures.Items[j].ToString() != t) continue;
                cbTreasures.Items.RemoveAt(j);
                break;
            }
        }

        if (cbTreasures.Items.Count > 0)
            cbTreasures.SelectedIndex = 0;
    }

    private List<string> GetTreasure()
    {
        var result = new List<string>();
        for (var i = 0; i < dataTreasures.Rows.Count; i++)
        {
            result.Add(dataTreasures.Rows[i].Cells[0].Value.ToString()!);
        }
        return result;
    }

    private void btnAddTreasures_Click(object sender, EventArgs e)
    {
        AddData(dataTreasures, cbTreasures, AddDataType.Normal);
    }

    private void btnRemoveTreasures_Click(object sender, EventArgs e)
    {
        RemoveRows(dataTreasures);
    }

    private void dataTreasures_SelectionChanged(object sender, EventArgs e)
    {
        EnableButton(dataTreasures, btnRemoveTreasures);
    }

    private void dataTreasures_MouseDown(object sender, MouseEventArgs e)
    {
        DataMouseDown(dataTreasures, e);
    }

    private void dataTreasures_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            RemoveRows(dataTreasures);
        }
    }

    #endregion Treasures

    #region Skill

    private void UpdateSkill()
    {
        foreach (var t in PublicClass.AppSetting.Profile.Skills)
        {
            dataSkill.Rows.Add(t.Name, t.Type.ToString());

            for (var j = 0; j < cbSkill.Items.Count; j++)
            {
                if (cbSkill.Items[j].ToString() != t.Name) continue;
                cbSkill.Items.RemoveAt(j);
                break;
            }
        }

        if (cbSkill.Items.Count > 0)
            cbSkill.SelectedIndex = 0;
    }

    private void btnAddSkill_Click(object sender, EventArgs e)
    {
        AddData(dataSkill, cbSkill, AddDataType.Skill);
    }

    private void btnRemoveSkill_Click(object sender, EventArgs e)
    {
        RemoveRows(dataSkill);
    }

    private void dataSkill_SelectionChanged(object sender, EventArgs e)
    {
        EnableButton(dataSkill, btnRemoveSkill);
    }

    private void dataSkill_MouseDown(object sender, MouseEventArgs e)
    {
        DataMouseDown(dataSkill, e);
    }

    private void dataSkill_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            RemoveRows(dataSkill);
        }
    }

    #endregion Skill

    #region Necro Rune

    private void UpdateNecromancy()
    {
        foreach (var t in PublicClass.AppSetting.Profile.Necromancy)
        {
            dataNecro.Rows.Add(t.Rune.ToStr(), t.Time, t.TimeResult);
        }
        if (cbNecro.Items.Count > 0)
            cbNecro.SelectedIndex = 0;
    }

    private List<Necromancy> GetNecromancy()
    {
        var result = new List<Necromancy>();
        for (var i = 0; i < dataNecro.Rows.Count; i++)
        {
            var rune = dataNecro.Rows[i].Cells[0].Value.ToString()!.ToNecromancy();
            var time = int.Parse(dataNecro.Rows[i].Cells[1].Value.ToString()!);
            var timeResult = dataNecro.Rows[i].Cells[2].Value.ToString()!;
            result.Add(new Necromancy(rune, time, timeResult));
        }
        return result;
    }

    private void btnAddNecro_Click(object sender, EventArgs e)
    {
        AddData(dataNecro, cbNecro, AddDataType.Necro);
    }

    private void btnRemoveNecro_Click(object sender, EventArgs e)
    {
        RemoveRows(dataNecro);
    }

    private void dataNecro_SelectionChanged(object sender, EventArgs e)
    {
        EnableButton(dataNecro, btnRemoveNecro);
    }

    private void dataNecro_MouseDown(object sender, MouseEventArgs e)
    {
        DataMouseDown(dataNecro, e);
    }

    private void dataNecro_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            RemoveRows(dataNecro);
        }
    }

    private void dataNecro_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (dataNecro.Rows.Count == 0) return;
        if (e.ColumnIndex == 1)
        {
            try
            {
                var time = int.Parse(dataNecro.Rows[e.RowIndex].Cells[1].Value.ToString()!).SecToMin();
                dataNecro.Rows[e.RowIndex].Cells[2].Value = time + " นาที";
            }
            catch
            {
                dataNecro.Rows[e.RowIndex].Cells[2].Value = "00:00 นาที";
            }
        }
    }

    #endregion Necro Rune

    #region Context Menu

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RemoveRows(GetData());
    }

    private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MoveUpDown(MoveType.MoveUp, GetData());
    }

    private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MoveUpDown(MoveType.MoveDown, GetData());
    }

    private DataGridView GetData()
    {
        var data = new DataGridView();
        if (tabControlMain.SelectedTab == tabHero)
        {
            data = dataHero;
        }
        if (tabControlMain.SelectedTab == tabTalent)
        {
            data = dataTalent;
        }
        if (tabControlMain.SelectedTab == tabTreasures)
        {
            data = dataTreasures;
        }
        if (tabControlMain.SelectedTab == tabSkill)
        {
            data = dataSkill;
        }
        if (tabControlMain.SelectedTab == tabNecromancy)
        {
            data = dataNecro;
        }
        return data;
    }

    #endregion Context Menu

    #region Utils Datagrid

    private static void AddData(DataGridView data, ComboBox combo, AddDataType type)
    {
        if (type == AddDataType.Normal)
        {
            data.Rows.Add(combo.SelectedItem.ToString());
        }

        if (type == AddDataType.Hero)
        {
            data.Rows.Add(combo.SelectedItem.ToString(), "Disable", "Disable");
        }

        if (type == AddDataType.Skill)
        {
            data.Rows.Add(combo.SelectedItem.ToString(), "Minor");
        }

        if (type == AddDataType.Necro)
        {
            data.Rows.Add(combo.SelectedItem.ToString(), "60", "01:00 นาที");
            return;
        }

        var index = combo.SelectedIndex;
        combo.Items.RemoveAt(index);
        try
        {
            if (index == 0)
            {
                combo.SelectedIndex = index;
            }

            if (index > 0)
            {
                combo.SelectedIndex = index;
            }

            if (index == combo.Items.Count - 1)
            {
                combo.SelectedIndex = index - 1;
            }
        }
        catch
        {
            //
        }
    }

    private static void EnableButton(DataGridView data, Button btn)
    {
        var selectedRowCount = data.Rows.GetRowCount(DataGridViewElementStates.Selected);
        btn.Enabled = selectedRowCount != 0;
    }

    private void DataMouseDown(DataGridView data, MouseEventArgs e)
    {
        var selectedRows = 0;
        var itemCount = 1;
        if (e.Button == MouseButtons.Right)
        {
            try
            {
                var hti = data.HitTest(e.X, e.Y);
                data.ClearSelection();
                data.Rows[hti.RowIndex].Selected = true;
                selectedRows = data.SelectedRows[0].Index;
                itemCount = data.RowCount - 1;
            }
            catch
            {
                //
            }

            if (data.SelectedRows.Count > 0)
            {
                removeToolStripMenuItem.Enabled = true;
                moveUpToolStripMenuItem.Enabled = selectedRows != 0;
                moveDownToolStripMenuItem.Enabled = selectedRows != itemCount;
            }
            else
            {
                removeToolStripMenuItem.Enabled = false;
                moveUpToolStripMenuItem.Enabled = false;
                moveDownToolStripMenuItem.Enabled = false;
            }
        }
    }

    private void RemoveRows(DataGridView data)
    {
        try
        {
            var selectedRowCount = data.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount != 0)
            {
                var listRemove = new List<int>();
                for (var i = 0; i < selectedRowCount; i++)
                {
                    listRemove.Add(data.SelectedRows[i].Index);

                    if (data == dataHero)
                    {
                        cbHeroes.Items.Add(dataHero.SelectedRows[i].Cells[0].Value.ToString()!);
                    }

                    if (data == dataTalent)
                    {
                        cbTalents.Items.Add(dataTalent.SelectedRows[i].Cells[0].Value.ToString()!);
                    }

                    if (data == dataTreasures)
                    {
                        cbTreasures.Items.Add(dataTreasures.SelectedRows[i].Cells[0].Value.ToString()!);
                    }

                    if (data == dataSkill)
                    {
                        cbSkill.Items.Add(dataSkill.SelectedRows[i].Cells[0].Value.ToString()!);
                    }
                }
                foreach (var row in listRemove.OrderByDescending(c => c))
                {
                    data.Rows.RemoveAt(row);
                }
                data.ClearSelection();

                if (data.Rows.Count > 0)
                {
                    var index = listRemove[^1];
                    if (index >= data.RowCount)
                    {
                        data.Rows[data.RowCount - 1].Selected = true;
                    }
                    else
                    {
                        data.Rows[index].Selected = true;
                    }
                }
            }
        }
        catch
        {
            //
        }
    }

    private static void MoveUpDown(MoveType type, DataGridView data)
    {
        try
        {
            var selectedRowCount = data.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount != 0)
            {
                var rowIndex = data.SelectedRows[0].Index;
                var newIndex = type == MoveType.MoveUp ? rowIndex - 1 : rowIndex + 1;
                var selectedRow = data.Rows[rowIndex];
                data.Rows.Remove(selectedRow);
                data.Rows.Insert(newIndex, selectedRow);
                data.ClearSelection();
                data.Rows[newIndex].Selected = true;
            }
        }
        catch
        {

        }
    }

    #endregion Utils Datagrid
}