namespace Devil_Awakening_Bot.Forms;

public partial class FrmMain : Form
{
    #region Variable

    #region API

    private readonly T5ive TFive = new();

    private readonly Action<string, LogType> _writeOutput;

    private static IntPtr _hwnd = IntPtr.Zero;

    #endregion API

    #region Bot

    private static bool _status, _pause, _dota, _randomEvents, _upSword, _endRound, _gift;

    private static bool _enter;

    private static int _currentRound = 1, _leaveTime, _pickTime, _necroTime, _bossWave, _bossTime, _upSwordTime;

    private static int _dotaRound, _totalRound, _winRound, _skipRound, _totalBoss, _totalMatchTime, _totalTimeRound, _totalTimeAll, _forceClose;

    private static BotStep _botStep = BotStep.Wait;

    private static Hero _hero = null!;

    private static Skill _skillW = new(), _skillE = new();

    private readonly Point _midScreen = new(960, 105);

    #endregion Bot

    #region User

    //private static string _limitUser = "";

    #endregion

    private static readonly FrmLog FrmLog = new();

    #endregion Variable

    public FrmMain(string args)
    {
        InitializeComponent();
        if (args == "Run")
        {
            Start();
        }

        _writeOutput = WriteOutput;
    }

    #region Load

    private void FrmMain_Load(object sender, EventArgs e)
    {
        LoadSettings();
        LoadLocation();
        GetAppHwnd();
        CheckFolder();

#if DEBUG
        testToolStripMenuItem.Visible = true;
#endif
    }

    private void LoadSettings()
    {
        topMostToolStripMenuItem.Checked = Settings.Default.TopMost;
        TopMost = Settings.Default.TopMost;

        //UserSystem.UserName = Settings.Default.User;
        //UserSystem.LoggedIn = Settings.Default.Login;
        //UserSystem.LimitWin = Settings.Default.Limit;
        //_limitUser = EncryptionPHP.DecryptString(UserSystem.LimitWin, "lnwza007");
        //UpdateMenu();
    }

    private void UpdateMenu()
    {
        //if (UserSystem.LoggedIn)
        //{
        //    registerBotToolStripMenuItem.Visible = false;
        //    logOutToolStripMenuItem.Visible = true;
        //}
        //else
        //{
        //    registerBotToolStripMenuItem.Visible = true;
        //    logOutToolStripMenuItem.Visible = false;
        //}
    }

    private void LoadLocation()
    {
        if (Settings.Default.Location == new Point(0, 0))
        {
            CenterToScreen();
        }
        else
        {
            Location = Settings.Default.Location;
        }
    }

    private static void GetAppHwnd()
    {
        _hwnd = Win32API.GetHwnd("Dota 2", "SDL_app");
    }

    private static void CheckFolder()
    {
        var logs = Path.Combine(PublicClass.AppPath, "Logs");
        if (!Directory.Exists(logs))
        {
            Directory.CreateDirectory(logs);
        }
    }

    #endregion Load

    #region Save

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        SaveLogs();
        SaveSetting();
    }

    private void SaveSetting()
    {
        Settings.Default.TopMost = topMostToolStripMenuItem.Checked;
        Settings.Default.Location = Location;
        Settings.Default.Save();
    }

    #endregion Save

    #region Start

    private void btnStart_Click(object sender, EventArgs e)
    {
        _botStep = BotStep.Arcade;
        Start();
    }

    private void Start()
    {
        _status = !_status;
        btnStart.Text = _status ? "Stop" : "Start";
        btnResume.Enabled = _status;
        btnEndRound.Enabled = _status;

        if (_status)
        {
            SetUpDota2();
            TFive.Win32.ActiveWindow(_hwnd);
            backgroundWorker1.RunWorkerAsync();
            CleanVars();
            tmCount.Start();
        }
        else
        {
            backgroundWorker1.CancelAsync();
            tmCount.Stop();
        }
    }

    private void SetUpDota2()
    {
        if (Win32API.CheckProcess("dota2")) return;

        TFive.Win32
        .OpenProgram(PublicClass.AppSetting.Profile.SteamPath, "steam://rungameid/570")
            .UserAction(_writeOutput, "�Դ�� Dota2", LogType.App)
            .Sleep(10 * 1000);
        OpenDota();
        GetAppHwnd();

        if (!_dota)
        {
            _dota = true;
            _dotaRound++;
        }
    }

    private static void CleanVars()
    {
        _leaveTime = PublicClass.AppSetting.Profile.LeaveTime;
        _pickTime = PublicClass.AppSetting.Profile.PickTime;
        _necroTime = PublicClass.AppSetting.Profile.NecroTime;
        _upSwordTime = PublicClass.AppSetting.Profile.UpSwordTime;
        _bossTime = 20;
        _totalTimeRound = 0;
        _totalMatchTime = 0;
        _bossWave = 0;
        _randomEvents = false;
        _upSword = false;
        _gift = false;
        _skillW = new Skill();
        _skillE = new Skill();
        _endRound = false;
        _enter = false;
    }

    #endregion Start

    #region Menu Strip

    private void logsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        if (logsToolStripMenuItem.Checked)
        {
            FrmLog.Show();
            var width = Screen.PrimaryScreen.Bounds.Width;
            var locationX = Location.X + Size.Width - 10;

            if (locationX > width - 650)
            {
                locationX = Location.X - 650;
            }

            FrmLog.Location = Location with { X = locationX };
        }
        else
        {
            FrmLog.Hide();
        }
    }

    private void profileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var frmProfile = new FrmProfile();
        frmProfile.ShowDialog();
        frmProfile.Dispose();
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var frmOption = new FrmOption();
        frmOption.ShowDialog();
        frmOption.Dispose();
    }

    private void registerBotToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //var input = TFiveInputBox.Show("Please enter your name");
        //var date = Utility.GetNistTime().ToString("yyyy/MM/dd");
        //UserSystem.UserName = input;
        //UserSystem.LoggedIn = true;
        //UserSystem.LimitWin = EncryptionPHP.EncryptString(Connection.GetLimit(UserSystem.UserName, date), "lnwza007");
        //if (UserSystem.LimitWin == "eUV01sQtGk0GSlfIs8oynA==")
        //{
        //    UserSystem.LimitWin = EncryptionPHP.EncryptString("0", "lnwza007");
        //    UserSystem.UserName = "";
        //    UserSystem.LoggedIn = false;
        //}
        //_limitUser = EncryptionPHP.DecryptString(UserSystem.LimitWin, "lnwza007");
        //lbTotal.Text = $"{_totalRound}/{_limitUser}";
        //UpdateMenu();
    }
    private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //UserSystem.UserName = "";
        //UserSystem.LoggedIn = false;

        //UpdateMenu();
    }


    #endregion Menu Strip

    #region Bot

    private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        var readyPath = new Point();

        while (!backgroundWorker1.CancellationPending)
        {
            if (!_status) continue;
            if (_pause) continue;

            CheckLimit();

            switch (_botStep)
            {
                #region ˹����ѡ Dota2

                case BotStep.Arcade:
                    {
                        if (CheckUpdate()) break;
                        CheckDisconnect();

                        LeaveEvents();

                        var result = TFive.Get.ImageWindows(_hwnd, Img.Arcade, PublicClass.CapturePath); // ������ʧ
                        if (result.Status)
                        {
                            TFive.Win32.ActiveWindow(_hwnd).Sleep(300);
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ ����व", LogType.Info)
                                .MoveMouseTo(_midScreen);
                            StepUp();
                            break;
                        }

                        result = TFive.Get.ImageWindows(_hwnd, Img.Arcade2, PublicClass.CapturePath); // ���ͧ�ʧ
                        if (result.Status)
                        {
                            TFive.Win32.ActiveWindow(_hwnd).Sleep(300);
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ ����व", LogType.Info)
                                .MoveMouseTo(_midScreen);
                            StepUp();
                            break;
                        }

                        result = TFive.Get.ImageWindows(_hwnd, Img.Start, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ �������", LogType.Info);
                            StepUp(BotStep.Accept);
                        }

                        break;
                    }

                case BotStep.Library:
                    {
                        if (CheckUpdate()) break;
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Library, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ ��ѧ", LogType.Info);
                            StepUp();
                        }
                        else
                        {
                            var arcade = TFive.Get.ImageWindows(_hwnd, Img.Arcade, PublicClass.CapturePath); // ������ʧ
                            if (arcade.Status)
                            {
                                TFive.Win32.ActiveWindow(_hwnd).Sleep(300);
                                TFive.Mouse.MoveMouseTo(arcade.Position).LeftButtonClick()
                                    .UserAction(_writeOutput, "��ԡ ����व", LogType.Info)
                                    .MoveMouseTo(_midScreen);
                            }
                        }

                        break;
                    }

                case BotStep.Devil:
                    {
                        if (CheckUpdate()) break;
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Devil, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ Devil", LogType.Info);
                            StepUp();
                        }

                        break;
                    }

                case BotStep.Lobby:
                    {
                        if (CheckUpdate()) break;
                        CheckDisconnect();

                        LeaveEvents();
                        TFive.Win32.Sleep(2000);
                        var result = TFive.Get.ImageWindowsArea(_hwnd, Img.Lobby, 1300, 500, 1750, 750, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ ���ҧ��駤����ͧ", LogType.Info);
                            StepUp();
                        }

                        break;
                    }

                case BotStep.Setting:
                    {
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Create, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            if (PublicClass.AppSetting.Profile.Episode == Episode.EP2)
                            {
                                TFive.Mouse.MoveMouseTo(1015, 395).LeftButtonClick()
                                    .UserAction(_writeOutput, "��ԡ Ἱ��� EP1", LogType.Info)
                                    .Sleep(500)
                                    .MoveMouseTo(1015, 465).LeftButtonClick()
                                    .UserAction(_writeOutput, "��ԡ ���͡Ἱ��� EP2", LogType.Info)
                                    .Sleep(500);
                            }

#if DEBUG
                            TFive.Mouse.MoveMouseTo(1010, 480).LeftButtonClick()
                                .Sleep(500)
                                .MoveMouseTo(1010, 710).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ �����ԧ���", LogType.Info)
                                .Sleep(500);
#endif

                            TFive.Mouse.MoveMouseTo(860, 685).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ ��ͧ����", LogType.Info)
                                .Sleep(500)
                                .Keyboard.KeyPress(VirtualKeyCode.NUMPAD1)
                                .UserAction(_writeOutput, "�觤�� 1", LogType.Info)
                                .Sleep(200)
                                .Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ ���ҧ", LogType.Info);
                            StepUp();
                        }

                        break;
                    }

                case BotStep.Start:
                    {
                        if (CheckUpdate()) break;
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Start, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ �������", LogType.Info);
                            StepUp();
                        }

                        break;
                    }

                case BotStep.Accept:
                    {
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Accept, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ ����Ѻ", LogType.Info); // ��ԡ����Ѻ
                            _totalRound++;
                            StepUp();
                        }

                        break;
                    }

                #endregion ˹����ѡ Dota2

                #region ���͡��ҹ ��������

                case BotStep.Level:
                    {
                        if (CheckReconnect()) break;

                        var lv = $"{PublicClass.AppSetting.Profile.Level}.png";
                        var files = Path.Combine(Img.LevelPath, lv);

                        var result = TFive.Get.ImageWindows(_hwnd, files, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, $"���͡�дѺ {PublicClass.AppSetting.Profile.Level}", LogType.Info);
                            StepUp();
                        }

                        break;
                    }

                case BotStep.SelectPath:
                    {
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Select, PublicClass.CapturePath); // �һ��� Select
                        if (result.Status)
                        {
                            readyPath = result.Position;
                            StepUp();
                        }
                        break;
                    }

                case BotStep.Hero:
                    {
                        var files = Directory.GetFiles(Img.HeroPath);
                        var list = (
                            from hero in PublicClass.AppSetting.Profile.Heroes
                            from file in files
                            where hero.Name == file.ToFileName()
                            select file).ToArray();

                        var endX = PublicClass.AppSetting.Profile.VIP ? 1795 : 1475;
                        var result = TFive.Get.ImageWindowsArea(_hwnd, list, 650, 925, endX, 975, PublicClass.CapturePath);

                        if (result.Status) // ����� �����
                        {
                            _hero = result.TargetName.GetHero();
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, $"��ԡ ���͡����� {_hero}", LogType.Info); // ���͡�����
                            StepUp();
                        }
                        else if (PublicClass.AppSetting.Profile.Refresh)
                        {
                            var resultRefresh = TFive.Get.ImageWindows(_hwnd, Img.Refresh, PublicClass.CapturePath);
                            if (resultRefresh.Status)
                            {
                                TFive.Mouse.MoveMouseTo(resultRefresh.Position).LeftButtonClick()
                                    .UserAction(_writeOutput, "��ԡ Refresh", LogType.Info)
                                    .Sleep(2000);

                                // ReSharper disable once RedundantJumpStatement
                                break; // �� Hero 9 ������
                            }
                        }
                        else
                        {
                            WriteOutput("�������������¡��", LogType.Info);
                            _skipRound++;
                            StepUp(BotStep.ForceExit);
                        }
                        break;
                    }

                case BotStep.Select:
                    {
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Select, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ Select", LogType.Info);
                            StepUp();
                        }
                        break;
                    }

                case BotStep.Apply:
                    {
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Apply, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(1745, 1000).LeftButtonClick()
                                .UserAction(_writeOutput, $"��ԡ Type 1", LogType.Info)
                                .Sleep(200)
                                .MoveMouseTo(result.Position).LeftButtonClick()
                                .Sleep(1000)
                                .UserAction(_writeOutput, "��ԡ Apply Type", LogType.Info);
                            StepUp();
                        }
                        break;
                    }

                case BotStep.Ready:
                    {
                        TFive.Mouse.Sleep(500).MoveMouseTo(readyPath).LeftButtonClick()
                            .UserAction(_writeOutput, "��ԡ Not Ready", LogType.Info);
                        StepUp();
                        break;
                    }

                #endregion ���͡��ҹ ��������

                #region Setup UI, Talents, Artifact

                case BotStep.Talent:
                    {
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Talent, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            UpArmor();
                            TFive.Mouse.Sleep(500)
                                .MoveMouseTo(result.Position).LeftButtonClick() // ��ԡ Talent
                                .Sleep(500);
                            Talents();
                            StepUp();
                        }
                        break;
                    }

                case BotStep.Artifact:
                    {
                        TFive.Keyboard.Sleep(500)
                            .KeyPress(VirtualKeyCode.VK_T)
                            .UserAction(_writeOutput, "������ T �Դ Artifact", LogType.Info)
                            .Sleep(500);

                        Artifact();

                        TFive.Keyboard.Sleep(500)
                            .KeyPress(VirtualKeyCode.VK_T)
                            .Sleep(200)
                            .KeyPress(VirtualKeyCode.VK_T)
                            .UserAction(_writeOutput, "������ T �Դ Artifact", LogType.Info);
                        StepUp();
                        break;
                    }

                case BotStep.Setup:
                    {
                        FirstSkill();
                        TFive.Keyboard
                            .KeyPress(VirtualKeyCode.F3)
                            .UserAction(_writeOutput, "������ F3 �����Դ��ѧ ��� Necro", LogType.Info)
                            .Sleep(300);
                        NecroClick(true);

                        if (PublicClass.AppSetting.Profile.Episode == Episode.EP2)
                        {
                            MoveToMiddle();
                        }
                        StepUp();
                        break;
                    }

                #endregion Setup UI, Talents, Artifact

                #region �����ҧ��

                case BotStep.InGame:
                    {
                        if (BossDetection()) break;

                        if (CheckReconnect()) break;

                        UpSword();

                        SkillDetection();
                        TreasuresDetection();
                        NormalClick();
                        NecroClick();

                        CheckDefeat();
                        break;
                    }

                #endregion �����ҧ��

                #region Boss

                case BotStep.Boss:
                    {
                        MoveToMiddle();
                        StepUp();
                    }
                    break;

                case BotStep.BossKilled:
                    {
                        KillingBoss();
                        var result = TFive.Get.ImageWindows(_hwnd, Img.BossOk, PublicClass.CapturePath);
                        if (result.Status) // ��к��
                        {
                            if (PublicClass.AppSetting.Profile.Episode == Episode.EP2)
                            {
                                TFive.Win32.Sleep(1000 * 10);
                            }
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ OK", LogType.Info)
                                .Sleep(1000)
                                .MoveMouseTo(80, 120).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ Player 1", LogType.Info)
                                .Sleep(300)
                                .MoveMouseTo(_midScreen);

                            _totalBoss++;
                            _bossWave++;

                            if (_bossWave <= 3) // �պ�� 4 ���
                            {
                                StepUp(BotStep.InGame); // ��͹��Ѻ�˹���� Devil
                                _enter = false;
                                continue;
                            }
                        }

                        LastBoss();
                        break;
                    }

                case BotStep.Abyss:
                    {
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Go, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ Go", LogType.Info)
                                .Sleep(1000)
                                .MoveMouseTo(955, 290).RightButtonHold(2000)
                                .UserAction(_writeOutput, "��ԡ �Թ�Һ�ʤ�ҧ 2 �Թҷ�", LogType.Info)
                                .Keyboard.KeyPress(VirtualKeyCode.VK_A)
                                .Sleep(200);
                            StepUp();
                        }
                        break;
                    }

                case BotStep.AbyssKilled:
                    {
                        KillingBoss();
                        var result = TFive.Get.ImageWindows(_hwnd, Img.TicketEnd, PublicClass.CapturePath); // ����͵���
                        if (result.Status)
                        {
                            StepUp();
                            break;
                        }

                        CheckDefeat();
                        break;
                    }

                #endregion Boss

                #region �͡�ҡ�� Devil

                case BotStep.End: // ˹�� Defeat, Victory Devil
                    {
                        CheckDefeat(true);
                        break;
                    }

                case BotStep.Disconnect:
                    {
                        if (CheckUpdate()) break;
                        LeaveEvents();
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Disconnect, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ �Ѵ�����������", LogType.Info)
                                .Sleep(1000);
                            StepUp();
                        }
                        break;
                    }

                case BotStep.Leave: // �͡�ҡ�� Devil
                    {
                        if (CheckUpdate()) break;
                        LeaveEvents();
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Leave, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ �͡�ҡ��", LogType.Info)
                                .Sleep(1000);
                            StepUp();
                        }
                        break;
                    }

                case BotStep.Leave2: // �������� "�׹�ѹ �͡�ҡ�� Devil"
                    {
                        LeaveEvents();
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Leave2, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ �� �͡�ҡ��", LogType.Info);
                            StepUp();
                        }
                        else
                        {
                            StepUp();
                        }
                        break;
                    }

                case BotStep.RoundUp:
                    {
                        RoundUp(); // �����ӹǹ�ͺ��診
                        break;
                    }

                case BotStep.ForceExit:
                    {
                        var result = TFive.Get.ImageWindows(_hwnd, Img.Exit, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ Exit ���", LogType.Info);

                            StepUp(BotStep.Disconnect);
                            break;
                        }

                        result = TFive.Get.ImageWindows(_hwnd, Img.Exit2, PublicClass.CapturePath);
                        if (result.Status)
                        {
                            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                                .UserAction(_writeOutput, "��ԡ Exit �˭�", LogType.Info);

                            StepUp(BotStep.Disconnect);
                        }
                        break;
                    }

                    #endregion �͡�ҡ�� Devil
            }
        }
    }

    #region Ingame

    private bool BossDetection()
    {
        var img = PublicClass.AppSetting.Profile.Episode == Episode.EP1 ? Img.BossEP1 : Img.BossEP2;
        var result = TFive.Get.ImageWindows(_hwnd, img, PublicClass.CapturePath);
        if (result.Status)
        {
            var leave = TFive.Get.ImageWindows(_hwnd, Img.TreasuresLeave, PublicClass.CapturePath);
            if (leave.Status)
            {
                TFive.Mouse.MoveMouseTo(leave.Position.SetTo(0, 65)).LeftButtonClick()
                    .UserAction(_writeOutput, "��ԡ ���ŧ ������͡ Treasures � �", LogType.Info);
            }
            StepUp();
            return true;
        }

        return false;
    }

    #region Count Time

    private void SkillDetection()
    {
        if (_skillW.IsMain && _skillE.IsMain) return;

        var files = Directory.GetFiles(Img.SkillPath);

        List<string> list;
        if (_skillW.IsActive && _skillE.IsActive)
        {
            list = (
                from skill in PublicClass.AppSetting.Profile.Skills
                from file in files
                where skill.Name == file.ToFileName()
                where skill.Name != _skillW.Name
                where skill.Name != _skillE.Name
                where skill.Type == SkillType.Major
                select file).ToList();
        }
        else
        {
            list = (
                from skill in PublicClass.AppSetting.Profile.Skills
                from file in files
                where skill.Name == file.ToFileName()
                where skill.Name != _skillW.Name
                where skill.Name != _skillE.Name
                select file).ToList();
        }

        var result = TFive.Get.ImageWindowsArea(_hwnd, list.ToArray(), 1595, 695, 1915, 865, PublicClass.CapturePath);

        if (result.Status)
        {
            if ((!_skillW.IsActive || !_skillE.IsActive) ||
                (_skillW.IsActive && _skillE.IsActive && (!_skillW.IsMain || !_skillE.IsMain)))
            {
                TFive.Mouse.MoveMouseTo(result.Position).RightButtonClick()
                .UserAction(_writeOutput, $"��ԡ ʡ�� {result.TargetName}", LogType.Info)
                .Sleep(500);
            }

            if (!_skillW.IsMain)
            {
                if (_skillW.IsActive && !_skillE.IsActive)
                {
                    goto skipToE;
                }

                if (_skillW.IsActive && result.TargetName.GetSkillType(PublicClass.AppSetting.Profile.Skills) != SkillType.Major) return;

                var point = result.Position.X <= 1740 ?
                    new Point(result.Position.X + 100, result.Position.Y - 35) :
                    new Point(result.Position.X - 100, result.Position.Y - 35);

                TFive.Mouse.MoveMouseTo(point).LeftButtonClick()
                    .UserAction(_writeOutput, $"��ԡ ����ʡ�� W - {result.TargetName}", LogType.Info);

                var skillResult = TFive.Get.ImageWindowsArea(_hwnd, Img.W, 920, 1010, 1120, 1025, PublicClass.CapturePath);
                if (skillResult.Status)
                {
                    if (!SkillManager.PassiveSkill.Any(s => s.Contains(result.TargetName)))
                    {
                        TFive.Mouse.Sleep(500)
                            .MovingMouseTo(skillResult.Position.SetTo(20)).RightButtonClick()
                            .UserAction(_writeOutput, $"��ԡ �Դʡ�� W - \"{result.TargetName}\"", LogType.Info)
                            .Sleep(200)
                            .MoveMouseTo(_midScreen);
                    }

                    if (result.TargetName.GetSkillType(PublicClass.AppSetting.Profile.Skills) == SkillType.Major)
                    {
                        _skillW.IsMain = true;
                    }

                    _skillW.IsActive = true;
                    _skillW.Name = result.TargetName;
                }
                return;
            }

        skipToE:

            if (!_skillE.IsMain)
            {
                if (_skillE.IsActive && result.TargetName.GetSkillType(PublicClass.AppSetting.Profile.Skills) != SkillType.Major) return;

                var pos = result.Position.X <= 1740 ?
                    result.Position with { X = result.Position.X + 100 } :
                    result.Position with { X = result.Position.X - 100 };

                TFive.Mouse.MoveMouseTo(pos).LeftButtonClick()
                    .UserAction(_writeOutput, $"��ԡ ����ʡ�� E - {result.TargetName}", LogType.Info);

                var skillResult = TFive.Get.ImageWindowsArea(_hwnd, Img.E, 920, 1010, 1120, 1025, PublicClass.CapturePath);
                if (skillResult.Status)
                {
                    if (!SkillManager.PassiveSkill.Any(s => s.Contains(result.TargetName)))
                    {
                        TFive.Mouse.Sleep(500)
                        .MovingMouseTo(skillResult.Position.SetTo(20)).RightButtonClick()
                        .UserAction(_writeOutput, $"��ԡ �Դʡ�� E - \"{result.TargetName}\"", LogType.Info)
                        .Sleep(200)
                        .MoveMouseTo(_midScreen);
                    }

                    if (result.TargetName.GetSkillType(PublicClass.AppSetting.Profile.Skills) == SkillType.Major)
                    {
                        _skillE.IsMain = true;
                    }

                    _skillE.IsActive = true;
                    _skillE.Name = result.TargetName;
                }
            }
        }
    }

    private void TreasuresDetection()
    {
        var leave = TFive.Get.ImageWindows(_hwnd, Img.TreasuresLeave, PublicClass.CapturePath);
        if (!leave.Status) // �������� X (Leave) - ˹�� Selecting Treasures
        {
            var result = TFive.Get.ImageWindowsArea(_hwnd, Img.Treasures4, 515, 960, 800, 1000, PublicClass.CapturePath);
            if (!result.Status) return; // �������� ���ͧ 4
            TFive.Keyboard.KeyPress(VirtualKeyCode.VK_4)
                .UserAction(_writeOutput, "�觤�� 4 �Դ���ͧ Treasures", LogType.Info);
        }

        TFive.Win32.Sleep(3000);

        TreasuresSelection(leave);
    }

    private void TreasuresSelection(ResultInfo info)
    {
        var files = Directory.GetFiles(Img.TreasuresPath);
        var list = (
            from treasure in PublicClass.AppSetting.Profile.Treasures
            from file in files
            where treasure == file.ToFileName()
            select file).ToArray();

        int startX;
        int endX;
        if (PublicClass.AppSetting.Profile.Gift || _gift)
        {
            startX = 210;
            endX = 1710;
        }
        else
        {
            startX = 530;
            endX = 1380;
        }
        var result = TFive.Get.ImageWindowsArea(_hwnd, list, startX, 220, endX, 360, PublicClass.CapturePath);

        if (result.Status) // ����� �����
        {
            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick() // ���ͧ
                .UserAction(_writeOutput, $"��ԡ Treasures: {result.TargetName}", LogType.Info)
                .Sleep(200)
                .MoveMouseTo(_midScreen);
            if (result.TargetName == "Gift of the Goddess")
            {
                _gift = true;
            }
        }
        else
        {
            if (info.Status) // ���������͡
            {
                TFive.Mouse.MoveMouseTo(info.Position).LeftButtonClick()
                    .UserAction(_writeOutput, "��ԡ �͡ ������͡ Treasures � �", LogType.Info)
                    .Sleep(200)
                    .MoveMouseTo(_midScreen);
            }
        }
    }

    private void NormalClick()
    {
        if (_pickTime <= 1 && _botStep == BotStep.InGame)
        {
            var result = TFive.Get.ImageWindowsArea(_hwnd, Img.Alt1, 1715, 930, 1900, 950, PublicClass.CapturePath);
            if (!result.Status) return;

            _pickTime = PublicClass.AppSetting.Profile.PickTime;

            TFive.Mouse.MoveMouseTo(1770, 874).LeftButtonClick()
                .UserAction(_writeOutput, "��ԡ �红ͧ", LogType.Info)
                .Sleep(200)
                .MoveMouseTo(_midScreen);

            if (!_skillW.IsMain || !_skillE.IsMain)
            {
                TFive.Mouse.MoveMouseTo(1703, 873).LeftButtonClick()
                    .UserAction(_writeOutput, "��ԡ �����ͧ", LogType.Info)
                    .Sleep(200)
                    .MoveMouseTo(_midScreen);
            }

            if (!_randomEvents)
            {
                var events = TFive.Get.ImageWindowsArea(_hwnd, Img.Event5, 515, 960, 800, 1000, PublicClass.CapturePath);
                if (events.Status)
                {
                    TFive.Keyboard.KeyPress(VirtualKeyCode.VK_5)
                        .UserAction(_writeOutput, "�觤�� 5 �Դ Random Events", LogType.Info);
                    _randomEvents = true;
                }
            }
        }
    }

    private void NecroClick(bool setup = false)
    {
        if ((_necroTime <= 1 && _botStep == BotStep.InGame) || setup)
        {
            var result = TFive.Get.ImageWindowsArea(_hwnd, Img.Alt1, 1715, 930, 1900, 950, PublicClass.CapturePath);
            if (!result.Status) return;

            _necroTime = PublicClass.AppSetting.Profile.NecroTime;

            var necromancy = _totalMatchTime.GetTime();
            var point = necromancy.GetPoint();

            TFive.Mouse.MoveMouseTo(point).RightButtonClick(10, 100)
                .UserAction(_writeOutput, $"��ԡ �Ѿ {necromancy}", LogType.Info)
                .Sleep(200)
                .MoveMouseTo(_midScreen);
        }
    }

    #endregion Count Time

    private void KillingBoss()
    {
        if (!_enter)
        {
            TFive.Win32.Sleep(5 * 1000);
            _enter = true;
        }
        if (_bossTime is 0)
        {
            _bossTime = 20;
            MoveToMiddle(1000);
        }

        var img = Path.Combine(Img.SpellActivePath, PublicClass.AppSetting.Profile.AwakingSpell.ToStr() + ".png");
        var result = TFive.Get.ImageWindowsArea(_hwnd, img, 1150, 1000, 1350, 1070, PublicClass.CapturePath);
        if (result.Status)
        {

            TFive.Mouse.MoveMouseTo(80, 120).LeftButtonClick()
                .UserAction(_writeOutput, "��ԡ Player 1", LogType.Info)
                .Sleep(300)
                .MoveMouseTo(960, 540) // ��ҧ, ��ҧ
                .Sleep(100);

            for (var i = 0; i < 4; i++)
            {
                if (_hero.SkillR == HeroSkillType.Manual)
                {
                    TFive.Keyboard.KeyPress(VirtualKeyCode.VK_R)
                        .Sleep(50);
                }

                TFive.Keyboard.KeyPress(VirtualKeyCode.VK_F)
                    .Sleep(50);

                if (_hero.SkillR == HeroSkillType.Manual)
                {
                    TFive.Keyboard.KeyPress(VirtualKeyCode.VK_R)
                        .Sleep(50);
                }
            }

            WriteOutput("������ F", LogType.Info);
        }
    }

    private void LastBoss()
    {
        if (_bossWave >= 4) // ����ͦ�Һ�ʵ�Ƿ�� 4 ������
        {
            if (PublicClass.AppSetting.Profile.Abyss)
            {
                _enter = false;
                StepUp(BotStep.Abyss);
                return;
            }

            StepUp(BotStep.End);
            return;
        }

        CheckDefeat();
    }

    private void MoveToMiddle(int ms = 0)
    {
        var ep = PublicClass.AppSetting.Profile.Episode == Episode.EP1 ? VirtualKeyCode.NUMPAD1 : VirtualKeyCode.NUMPAD2;
        if (ms == 0)
        {
            ms = PublicClass.AppSetting.Profile.Episode == Episode.EP1 ? 1000 * 10 : 1000 * 3;
        }

        TFive.Keyboard.Sleep(500)
            .KeyPress(ep)
            .UserAction(_writeOutput, $"�� {ep}", LogType.Info)
            .Sleep(500)
            .Mouse.MoveMouseTo(960, 540).RightButtonHold(ms)
            .UserAction(_writeOutput, $"��ԡ �Թ仡�ҧ�����ҧ {ms / 1000} �Թҷ�", LogType.Info)
            .Sleep(200)
            .Keyboard.KeyPress(VirtualKeyCode.VK_A)
            .Sleep(200)
            .Mouse.MoveMouseTo(_midScreen);
    }

    private void UpSword()
    {
        if (_upSword) return;
        if (PublicClass.AppSetting.Profile.UpSword && _upSwordTime <= 0)
        {
            var sword = TFive.Get.ImageWindowsArea(_hwnd, Img.Sword1, 515, 960, 800, 1000, PublicClass.CapturePath);
            if (sword.Status)
            {
                TFive.Mouse.MoveMouseTo(sword.Position.SetTo(5)).RightButtonClick()
                    .UserAction(_writeOutput, "��ԡ �Ѿ�ô \"�Һ\" ������ͧ", LogType.Info)
                    .Sleep(500)
                    .MoveMouseTo(_midScreen); // ���������仡�ҧ��
                _upSword = true;
                return;
            }
        }

        var armorList = new List<string> { Img.ArmorRed, Img.ArmorRed2, Img.ArmorRed3, Img.ArmorRed4 };
        var armorRed = TFive.Get.ImageWindowsAreaList(_hwnd, armorList.ToArray(), 515, 960, 800, 1010, PublicClass.CapturePath);
        foreach (var result in from armor in armorRed
                               where armor.Status
                               select TFive.Get.ImageWindowsArea(_hwnd, Img.Sword1, 515, 960, 800, 1000, PublicClass.CapturePath)
                 into result
                               where result.Status
                               select result)
        {
            TFive.Mouse.MoveMouseTo(result.Position.SetTo(5)).RightButtonClick()
                .UserAction(_writeOutput, "��ԡ �Ѿ�ô \"�Һ\" ������ͧ", LogType.Info)
                .Sleep(500)
                .MoveMouseTo(_midScreen); // ���������仡�ҧ��
            _upSword = true;
            break;
        }
    }

    #endregion Ingame

    #region Setup

    private void UpArmor()
    {
        var result = TFive.Get.ImageWindowsArea(_hwnd, Img.Armor2, 515, 960, 800, 1000, PublicClass.CapturePath);
        if (result.Status)
        {
            TFive.Mouse.MoveMouseTo(result.Position.SetTo(5)).RightButtonClick()
                .UserAction(_writeOutput, "��ԡ �Ѿ�ô \"����\" ������ͧ", LogType.Info)
                .Sleep(500);
        }
    }

    private void Talents()
    {
        var files = Directory.GetFiles(Img.TalentPath);
        var list = (
            from talent in PublicClass.AppSetting.Profile.Talents
            from file in files
            where talent.ToStr() == file.ToFileName()
            select file).ToArray();

        var result = TFive.Get.ImageWindowsAreaList(_hwnd, list, 720, 760, 990, 890, PublicClass.CapturePath);

        foreach (var info in result.Where(info => info.Status))
        {
            TFive.Mouse.MoveMouseTo(info.Position).RightButtonClick()
                .UserAction(_writeOutput, $"��ԡ �Ѿ Talent \"{info.TargetName}\"", LogType.Info)
                .Sleep(200);
        }
    }

    private void Artifact()
    {
        var files = Directory.GetFiles(Img.ArtifactPath);
        var list = (
            from artifact in PublicClass.AppSetting.Profile.Artifacts
            from file in files
            where artifact.ToStr() == file.ToFileName()
            select file).ToArray();

        var result = TFive.Get.ImageWindowsAreaList(_hwnd, list, 1130, 850, 1510, 910, PublicClass.CapturePath);

        foreach (var info in result.Where(info => info.Status))
        {
            TFive.Mouse.MoveMouseTo(info.Position).LeftButtonClick()
                .UserAction(_writeOutput, $"��ԡ Artifact \"{info.TargetName}\"", LogType.Info)
                .Sleep(500);
        }

        AwakingSpell();
    }

    private void AwakingSpell()
    {
        var img = Path.Combine(Img.SpellPath, PublicClass.AppSetting.Profile.AwakingSpell.ToStr() + ".png");

        TFive.Mouse.MoveMouseTo(1365, 800).LeftButtonClick()
            .UserAction(_writeOutput, "��ԡ Awaking Spell", LogType.Info)
            .Sleep(300);

        var result = TFive.Get.ImageWindowsArea(_hwnd, img, 1125, 850, 1520, 910, PublicClass.CapturePath);

        if (result.Status)
        {
            TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                .UserAction(_writeOutput, $"��ԡ Spell \"{result.TargetName}\"", LogType.Info)
                .Sleep(500);
        }
    }

    private void FirstSkill()
    {
        var list = new[] { Img.Q, Img.R };
        var result = TFive.Get.ImageWindowsAreaList(_hwnd, list, 920, 1010, 1120, 1025, PublicClass.CapturePath);

        foreach (var info in result.Where(info => info.Status))
        {
            if ((info.TargetName.Contains("Q") && _hero.SkillQ != HeroSkillType.Auto) ||
                info.TargetName.Contains("R") && _hero.SkillR != HeroSkillType.Auto)
            {
                continue;
            }
            TFive.Mouse.MoveMouseTo(info.Position.SetTo(10)).RightButtonClick()
                .UserAction(_writeOutput, $"��ԡ �Դʡ�� \"{info.TargetName}\"", LogType.Info)
                .Sleep(500);
        }

        TFive.Mouse.MoveMouseTo(_midScreen);
    }

    #endregion Setup

    #region General

    private void CheckDefeat(bool skip = false)
    {
        if (_leaveTime > 0 && !skip) return;

        var result = TFive.Get.ImageWindows(_hwnd, Img.TicketEnd, PublicClass.CapturePath); // ����͵���
        if (result.Status)
        {
            if (skip) // ��Ҫ��
            {
                ExtraOpen();
                _winRound++;
            }
            else // �����
            {
                WriteOutput("�ѧ�Ѻ�͡ - ��", LogType.Info);
                _forceClose++;
            }

            if (_endRound)
            {
                Pause();
                RoundUp(); // �����ӹǹ�ͺ��診
                return;
            }

            StepUp(BotStep.ForceExit); // �ѧ�Ѻ�͡
        }
    }

    private void ExtraOpen()
    {
        if (PublicClass.AppSetting.Profile.Ticket)
        {
            TFive.Win32.Sleep(8000);
            var result = TFive.Get.ImageWindowsArea(_hwnd, Img.TicketPlus, 770, 835, 1150, 935, PublicClass.CapturePath);
            if (result.Status)
            {
                if (PublicClass.AppSetting.Profile.Abyss)
                {
                    TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                        .Sleep(200)
                        .LeftButtonClick()
                        .Sleep(500)
                        .UserAction(_writeOutput, "��ԡ Ticket Abyss", LogType.Info)
                        .Sleep(500)
                        .MoveMouseTo(245, 95).LeftButtonClick()
                        .Sleep(1000);
                }
                TFive.Mouse.MoveMouseTo(result.Position).LeftButtonClick()
                    .Sleep(200)
                    .LeftButtonClick()
                    .Sleep(500)
                    .UserAction(_writeOutput, "��ԡ Ticket Team", LogType.Info);
            }
        }
    }

    private void CheckLimit()
    {
        if (!Win32API.CheckProcess("Steam"))
        {
            TFive.Win32.OpenProgram(PublicClass.AppSetting.Profile.SteamPath)
                .UserAction(_writeOutput, "�Դ Steam", LogType.App)
                .Sleep(1000 * 30);
            return;
        }

        if (_currentRound > PublicClass.AppSetting.Profile.LimitRound && _botStep < BotStep.ExitDota)
        {
            try
            {
                TFive.Win32.CloseProcess("dota2")
                    .UserAction(_writeOutput, "�ѧ�Ѻ �Դ�� Dota2", LogType.App)
                .Sleep(5000);

                if (Win32API.CheckProcess("dota2"))
                {
                    return;
                }

                _dota = false;
                _botStep = BotStep.StartDota;
            }
            catch
            {
                WriteOutput("�Դ����������", LogType.Error);
            }
        }

        if (_botStep >= BotStep.StartDota && !Win32API.CheckProcess("dota2"))
        {
            TFive.Win32.Sleep(10 * 1000);
            SetUpDota2();

            _currentRound = 1;
            _botStep = BotStep.Arcade;
            CleanVars();
        }
    }

    private bool CheckUpdate()
    {
        var update = TFive.Get.ImageWindows(_hwnd, Img.Update, PublicClass.CapturePath).Status;
        if (update)
        {
            WriteOutput("������Ѿഷ", LogType.App);
            TFive.Win32.CloseProcess("dota2")
                .UserAction(_writeOutput, "�Դ�� Dota2", LogType.App)
                .Sleep(5000);

            _dota = false;
            TFive.Win32.Sleep(1000 * 60 * 3);
            _botStep = BotStep.StartDota;
            return true;
        }

        return false;
    }

    private bool CheckReconnect()
    {
        var reconnect = TFive.Get.ImageWindows(_hwnd, Img.Reconnect, PublicClass.CapturePath);
        if (reconnect.Status)
        {
            TFive.Mouse.MoveMouseTo(reconnect.Position).LeftButtonClick()
                .UserAction(_writeOutput, "�������������ա����", LogType.Info);
            return ReSetUp();
        }

        return false;
    }

    private bool ReSetUp()
    {
        while (true)
        {
            var result = TFive.Get.ImageWindows(_hwnd, Img.Talent, PublicClass.CapturePath);
            if (result.Status)
            {
                TFive.Keyboard.KeyPress(VirtualKeyCode.VK_5)
                    .UserAction(_writeOutput, "�觤�� 5 �Դ Random Events", LogType.Info)
                    .Sleep(500)
                    .KeyPress(VirtualKeyCode.F3)
                    .UserAction(_writeOutput, "������ F3 �����Դ��ѧ ��� Necro", LogType.Info)
                    .Sleep(300);
                break;
            }
        }

        return true;
    }

    private void CheckDisconnect()
    {
        var disconnect = TFive.Get.ImageWindows(_hwnd, Img.Disconnect, PublicClass.CapturePath);
        if (disconnect.Status)
        {
            TFive.Mouse.MoveMouseTo(disconnect.Position).LeftButtonClick()
                .UserAction(_writeOutput, "��ԡ �Ѵ����������� �����", LogType.Info)
                .Sleep(10 * 1000);
        }

        var leave = TFive.Get.ImageWindows(_hwnd, Img.Leave, PublicClass.CapturePath);
        if (leave.Status)
        {
            TFive.Mouse.MoveMouseTo(leave.Position).LeftButtonClick()
                .UserAction(_writeOutput, "��ԡ �͡�ҡ�� �����", LogType.Info)
                .Sleep(1000);
        }
    }

    private void LeaveEvents()
    {
        var events = TFive.Get.ImageWindowsArea(_hwnd, Img.LeaveEvents, 1510, 290, 1560, 325, PublicClass.CapturePath);
        if (events.Status)
        {
            TFive.Mouse.MoveMouseTo(events.Position).LeftButtonClick()
                .UserAction(_writeOutput, "��ԡ �͡ Events", LogType.Info)
                .Sleep(1000);
        }
    }

    private void OpenDota()
    {
        while (!Win32API.CheckProcess("Dota2"))
        {
            var playDota = TFive.Get.ImageScreen(Img.PlayDota, PublicClass.CapturePath);
            if (playDota.Status)
            {
                TFive.Mouse.MoveMouseTo(playDota.Position).LeftButtonClick()
                    .UserAction(_writeOutput, "��ԡ �Դ��", LogType.Info)
                    .Sleep(1000);
            }

            var forcePlay = TFive.Get.ImageScreen(Img.ForcePlay, PublicClass.CapturePath);
            if (forcePlay.Status)
            {
                TFive.Mouse.MoveMouseTo(forcePlay.Position).LeftButtonClick()
                    .UserAction(_writeOutput, "��ԡ ��������", LogType.Info)
                    .Sleep(1000);
            }
            TFive.Win32.Sleep(1000);
        }
    }

    #endregion General

    #region Utils

    private void StepUp(BotStep skip = BotStep.Arcade)
    {
        _leaveTime = PublicClass.AppSetting.Profile.LeaveTime;
        if (skip != 0)
        {
            _botStep = skip;
            WriteOutput(_botStep.ToStr(), LogType.Bot);
            return;
        }
        _botStep++;
        WriteOutput(_botStep.ToStr(), LogType.Bot);
    }

    private void RoundUp()
    {
        WriteOutput($"���ͺ��� {_totalRound}", LogType.Info);

        WriteOutput($"�ͺ��� {_totalRound} ��������� {_totalMatchTime.SecToMin()} �ҷ�", LogType.Info);
        WriteOutput($"�����ҷ����� {_totalTimeRound.SecToMin()} �ҷ�\n" +
                    "==========================", LogType.Info);
        CleanVars();
        _currentRound++;
        if (_currentRound > PublicClass.AppSetting.Profile.LimitRound) return;

        WriteOutput($"�����������ͺ��� {_totalRound + 1}", LogType.Info);

        StepUp(BotStep.Lobby); // ���ҧ��ͧ����
    }

    #endregion Utils

    private void tmCount_Tick(object sender, EventArgs e)
    {
        _totalTimeRound++;
        _totalTimeAll++;

        if (_botStep >= BotStep.Talent)
        {
            _totalMatchTime++;
            _upSwordTime--;
        }

        if (_pause) return;
        if (_botStep is BotStep.InGame)
        {
            _pickTime--;
            _necroTime--;
        }

        if (_botStep is BotStep.BossKilled or BotStep.AbyssKilled)
        {
            _bossTime--;
        }

        _leaveTime--;

        if (_leaveTime <= 0)
        {
            _currentRound = PublicClass.AppSetting.Profile.LimitRound + 1;
        }
    }

    #endregion Bot

    #region Events

    private void btnResume_Click(object sender, EventArgs e)
    {
        Pause();
    }

    private void Pause()
    {
        if (btnResume.Text == "Pause")
        {
            btnResume.Text = "Resume";
            _pause = true;
            btnStart.Enabled = false;
            return;
        }

        if (btnResume.Text == "Resume")
        {
            btnResume.Text = "Pause";
            _pause = false;
            btnStart.Enabled = true;
        }
    }

    private void btnEndRound_Click(object sender, EventArgs e)
    {
        _endRound = !_endRound;
        btnEndRound.Text = _endRound ? "Cancel" : "End Round";
    }

    private void topMostToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        TopMost = topMostToolStripMenuItem.Checked;
    }

    private void tmUI_Tick(object sender, EventArgs e)
    {
        lbTotal.Text = _totalRound.ToString();
        lbWin.Text = _winRound.ToString();
        lbBoss.Text = _totalBoss.ToString();
        lbForceClose.Text = _forceClose.ToString();
        lbRound.Text = $"{_currentRound}/{PublicClass.AppSetting.Profile.LimitRound}";

        lbBotStep.Text = _botStep.ToStr();
        lbWave.Text = _bossWave >= 5 ? "4/4" : $"{_bossWave}/4";

        lbPick.Text = _pickTime <= 0 ? "00:00 �ҷ�" : _pickTime.SecToMin() + " �ҷ�";
        lbNecro.Text = _necroTime <= 0 ? "00:00 �ҷ�" : _necroTime.SecToMin() + " �ҷ�";
        lbExit.Text = _leaveTime <= 0 ? "00:00 �ҷ�" : _leaveTime.SecToMin() + " �ҷ�";
    }

    #endregion Events

    #region Logs

    private string _lastOutPut = "";

    private static void AppendText(RichTextBox box, string text, string strColor, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;
        box.SelectionColor = color;
        box.AppendText(strColor);
        box.SelectionColor = box.ForeColor;
        box.AppendText(text);
        box.ScrollToCaret();
    }

    private void TextToLogs(string str, string strColor, Color color)
    {
        Invoke(new MethodInvoker(delegate
        {
            AppendText(FrmLog.txtLogs, str, strColor, color);
        }));
    }

    public void WriteOutput(string str, LogType type)
    {
        if (CheckOutput(str, type)) return;
        if (str.Equals(_lastOutPut)) return;
        _lastOutPut = str;

        var time = DateTime.Now.ToString("h:mm:ss");

        var header = $"[ {time} ] {type}: ";

        var color = type switch
        {
            LogType.Bot => Color.Gold,
            LogType.Info => Color.DodgerBlue,
            LogType.Error => Color.Red,
            LogType.App => Color.White,
            _ => new Color()
        };

        TextToLogs(str + Environment.NewLine, header, color);
    }

    private static bool CheckOutput(string str, LogType type)
    {
        if (type == LogType.App) return false;

        if (!PublicClass.AppSetting.Option.Log.SteamDotaLog)
        {
            if (str.Equals("�Դ Steam") || str.Contains("�Դ�� Dota2") || str.Equals("�Դ����������"))
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.UpdateLog)
        {
            if (str.Equals("������Ѿഷ"))
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.BotLog)
        {
            if (type == LogType.Bot)
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.General)
        {
            if (str.Contains("�������������ա����"))
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.MainLog)
        {
            if (_botStep is >= BotStep.Arcade and <= BotStep.Accept)
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.PrepareLog)
        {
            if (_botStep is >= BotStep.Level and <= BotStep.Ready)
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.SetupLog)
        {
            if (_botStep is >= BotStep.Talent and <= BotStep.Setup)
                return true;

            if (str.Contains("�Һ") || str.Contains("Random Events"))
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.LeaveLog)
        {
            if (_botStep is >= BotStep.End and <= BotStep.Leave2 or BotStep.ForceExit)
                return true;

            if (str.Contains("Ticket"))
                return true;

            if (str.Contains("������"))
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.RoundLog)
        {
            if (_botStep is BotStep.RoundUp)
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.SkillLog)
        {
            if (str.Contains("ʡ��"))
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.TreasuresLog)
        {
            if (str.Contains("Treasures"))
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.InGameLog)
        {
            if (str.Contains("�� ") || str.Contains("�Թ仡�ҧ�����ҧ") || str.Contains("��ԡ �Ѿ ") || str.Contains("�红ͧ") || str.Contains("�����ͧ"))
                return true;
        }

        if (!PublicClass.AppSetting.Option.Log.BossLog)
        {
            if (_botStep is >= BotStep.Boss and <= BotStep.AbyssKilled)
                return true;
        }

        return false;
    }

    public void SaveLogs()
    {
        if (!PublicClass.AppSetting.Option.Log.AutoSaveLogs) return;
        if (string.IsNullOrWhiteSpace(FrmLog.txtLogs.Text)) return;
        var date = DateTime.Now.ToString("yyyy-M-d HH-mm-ss");
        var path = $"{PublicClass.AppPath}\\Logs\\{date}.txt";
        var state = "\n============================\n" +
                    $"�ͺ������: {_totalRound} �ͺ\n" +
                    $"��з�����: {_winRound} ����\n" +
                    $"����������: {_skipRound} ����\n" +
                    $"�ӹǹ��ʷ�����������: {_totalBoss} ���\n" +
                    $"�ӹǹ�Դ��������: {_dotaRound} ����\n" +
                    $"�����Һͷ������: {_totalTimeAll.SecToHour()} ��.\n" +
                    "============================";
        Invoke(new MethodInvoker(delegate
        {
            File.WriteAllText(path, FrmLog.txtLogs.Text + state);
        }));

        WriteOutput($"Log saved successfully. \"{path}\"", LogType.App);
    }

    #endregion Logs

    #region Test

    private void testToolStripMenuItem_Click(object sender, EventArgs e)
    {

        //EncryptionPHP.start2();

        //_currentRound = PublicClass.AppSetting.Profile.LimitRound + 1;
        //var pnt = TFive.Get.ImageScreen(Img.PlayDota, PublicClass.CapturePath);
        //if (pnt.Status)
        //{
        //    TFive.Mouse.MoveMouseTo(pnt.Position).LeftButtonClick();
        //}
        //TFive.Win32.OpenProgram(PublicClass.AppSetting.Profile.SteamPath, "steam://rungameid/570");
        //WriteOutput("��ԡ Player 1", LogType.Info);
        //Debug.WriteLine(Path.Combine(Img.SpellActivePath, PublicClass.AppSetting.Profile.AwakingSpell.ToStr() + ".png"));
        //GetAppHwnd();
        //SkillDetection();
        //CaptureSkill();
        //TFive.Capture.CaptureArea(_hwnd, 1595, 695, 1915, 865); // Cap Main

        //Artifact();
        //TFive.Win32.ActiveWindow(_hwnd)
        //    .Sleep(500)
        //    .Keyboard.ModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.VK_Q);
        //CaptureTreasures();
        //CaptureHero();
        //var img = Image.FromFile(@"D:\Visual Studio 2022\C#\Devil-Awakening-Bot\Devil-Awakening-Bot\bin\Debug\net6.0-windows\Dota2\Devil\alt1.png");
        //var result = TFive.Get.ImageWindowsArea(_hwnd, img, 1715, 930, 1900, 950);
        //Debug.WriteLine(result.TargetName);
        //result = targetname
    }

    private void heroToolStripMenuItem_Click(object sender, EventArgs e)
    {

        var name = (string)toolStripComboBox1.SelectedItem;
        _hero = new Hero(name, HeroSkillType.Disable, HeroSkillType.Disable);
    }

    private void stepToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _botStep = (BotStep)toolStripComboBox2.SelectedIndex;
    }

    private void bossToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _bossWave = toolStripComboBox3.SelectedIndex;
    }

    //private void CaptureSkill()
    //{
    //    var main = TFive.Capture.CaptureIArea(_hwnd, 1595, 695, 1915, 865); // Cap Main

    //    CaptureSkillMain(main, 26 + (52 * 0), 26 + (52 * 0), 26 + 20 + (52 * 0), 26 + 20 + (52 * 0)); // 1, 1
    //    CaptureSkillMain(main, 26 + (52 * 1), 26 + (52 * 0), 26 + 20 + (52 * 1), 26 + 20 + (52 * 0)); // 1, 2
    //    CaptureSkillMain(main, 26 + (52 * 2), 26 + (52 * 0), 26 + 20 + (52 * 2), 26 + 20 + (52 * 0)); // 1, 3
    //    CaptureSkillMain(main, 26 + (52 * 3), 26 + (52 * 0), 26 + 20 + (52 * 3), 26 + 20 + (52 * 0)); // 1, 4
    //    CaptureSkillMain(main, 26 + (52 * 4), 26 + (52 * 0), 26 + 20 + (52 * 4), 26 + 20 + (52 * 0)); // 1, 5
    //    CaptureSkillMain(main, 26 + (52 * 5), 26 + (52 * 0), 26 + 20 + (52 * 5), 26 + 20 + (52 * 0)); // 1, 6

    //    CaptureSkillMain(main, 26 + (52 * 0), 26 + (52 * 1), 26 + 20 + (52 * 0), 26 + 20 + (52 * 1)); // 2, 1
    //    CaptureSkillMain(main, 26 + (52 * 1), 26 + (52 * 1), 26 + 20 + (52 * 1), 26 + 20 + (52 * 1)); // 2, 2
    //    CaptureSkillMain(main, 26 + (52 * 2), 26 + (52 * 1), 26 + 20 + (52 * 2), 26 + 20 + (52 * 1)); // 2, 3
    //    CaptureSkillMain(main, 26 + (52 * 3), 26 + (52 * 1), 26 + 20 + (52 * 3), 26 + 20 + (52 * 1)); // 2, 4
    //    CaptureSkillMain(main, 26 + (52 * 4), 26 + (52 * 1), 26 + 20 + (52 * 4), 26 + 20 + (52 * 1)); // 2, 5
    //    CaptureSkillMain(main, 26 + (52 * 5), 26 + (52 * 1), 26 + 20 + (52 * 5), 26 + 20 + (52 * 1)); // 2, 6

    //    CaptureSkillMain(main, 26 + (52 * 0), 26 + (52 * 2), 26 + 20 + (52 * 0), 26 + 20 + (52 * 2)); // 3, 1
    //    CaptureSkillMain(main, 26 + (52 * 1), 26 + (52 * 2), 26 + 20 + (52 * 1), 26 + 20 + (52 * 2)); // 3, 2
    //    CaptureSkillMain(main, 26 + (52 * 2), 26 + (52 * 2), 26 + 20 + (52 * 2), 26 + 20 + (52 * 2)); // 3, 3
    //    CaptureSkillMain(main, 26 + (52 * 3), 26 + (52 * 2), 26 + 20 + (52 * 3), 26 + 20 + (52 * 2)); // 3, 4
    //    CaptureSkillMain(main, 26 + (52 * 4), 26 + (52 * 2), 26 + 20 + (52 * 4), 26 + 20 + (52 * 2)); // 3, 5
    //    CaptureSkillMain(main, 26 + (52 * 5), 26 + (52 * 2), 26 + 20 + (52 * 5), 26 + 20 + (52 * 2)); // 3, 6
    //}

    //private static void CaptureSkillMain(Image main, int startX, int startY, int endX, int endY)
    //{
    //    var skillPath = Path.Combine(PublicClass.AppPath, "CSkill");
    //    var files = Directory.GetFiles(skillPath);
    //    var name = (files.Length + 1).ToString();

    //    var nameMain = $"{name}.png";
    //    var pathMain = Path.Combine(skillPath, nameMain);

    //    var bitmap = ImageHelper.CropImage(main, ImageHelper.GetRectangle(startX, startY, endX, endY));
    //    bitmap.Save(pathMain, ImageFormat.Png);
    //}

    //private void CaptureTreasures()
    //{
    //    var main = TFive.Capture.CaptureIArea(_hwnd, 531, 224, 1390, 560); // Cap Main
    //    //var main = Image.FromFile(@"D:\Users\TFive\Pictures\Screenshots\Screenshot (199).png");
    //    //main = ImageHelper.CropImage(main, new Rectangle(531, 224, 859, 336));
    //    CaptureTreasuresMain(main, 0, 0, 227, 336);
    //    CaptureTreasuresMain(main, 315, 0, 542, 336);
    //    CaptureTreasuresMain(main, 630, 0, 857, 336);
    //}

    //private static void CaptureTreasuresMain(Image main, int startX, int startY, int endX, int endY)
    //{
    //    var treasuresPath = Path.Combine(PublicClass.AppPath, "CTreasures");
    //    var files = Directory.GetFiles(treasuresPath);
    //    var name = files.Length > 0 ?
    //        ((files.Length / 2) + 1).ToString() :
    //        (files.Length + 1).ToString();

    //    var nameMain = $"{name}.png";
    //    var pathMain = Path.Combine(treasuresPath, nameMain);

    //    var bitmap = ImageHelper.CropImage(main, ImageHelper.GetRectangle(startX, startY, endX, endY));
    //    bitmap.Save(pathMain, ImageFormat.Png);

    //    CaptureTreasuresChild(bitmap, 100, 55, 130, 85, name);
    //}

    //private static void CaptureTreasuresChild(Image main, int startX, int startY, int endX, int endY, string name)
    //{
    //    var treasuresPath = Path.Combine(PublicClass.AppPath, "CTreasures");
    //    var nameMain = $"{name}-{name}.png";
    //    var pathMain = Path.Combine(treasuresPath, nameMain);

    //    var bitmap = ImageHelper.CropImage(main, ImageHelper.GetRectangle(startX, startY, endX, endY));
    //    bitmap.Save(pathMain, ImageFormat.Png);
    //}

    //private void CaptureHero()
    //{
    //    var main = TFive.Capture.CaptureIArea(_hwnd, 650, 925, 1474, 975); // Cap Main
    //    //var main = ImageHelper.CropImage(Image.FromFile(@"D:\Users\TFive\Pictures\Screenshots\Screenshot (147).png"), ImageHelper.GetRectangle(650, 925, 1474, 975)); // Cap Main
    //    //main.Save(Path.Combine(PublicClass.AppPath, "CHero", "main.png"));

    //    CaptureHeroMain(main, 0, 0, 174, 50);
    //    CaptureHeroMain(main, 325, 0, 499, 50);
    //    CaptureHeroMain(main, 650, 0, 824, 50);
    //}

    //private static void CaptureHeroMain(Image main, int startX, int startY, int endX, int endY)
    //{
    //    var HeroPath = Path.Combine(PublicClass.AppPath, "CHero");
    //    var files = Directory.GetFiles(HeroPath);
    //    var name = files.Length > 0 ?
    //        ((files.Length / 2) + 1).ToString() :
    //        (files.Length + 1).ToString();
    //    //var name = files.Length.ToString();

    //    var nameMain = $"{name}.png";
    //    var pathMain = Path.Combine(HeroPath, nameMain);

    //    var bitmap = ImageHelper.CropImage(main, ImageHelper.GetRectangle(startX, startY, endX, endY));
    //    bitmap.Save(pathMain, ImageFormat.Png);

    //    CaptureHeroChild(bitmap, 72, 8, 104, 40, name);
    //}

    //private static void CaptureHeroChild(Image main, int startX, int startY, int endX, int endY, string name)
    //{
    //    var treasuresPath = Path.Combine(PublicClass.AppPath, "CHero");
    //    var nameMain = $"{name}-{name}.png";
    //    var pathMain = Path.Combine(treasuresPath, nameMain);

    //    var bitmap = ImageHelper.CropImage(main, ImageHelper.GetRectangle(startX, startY, endX, endY));
    //    bitmap.Save(pathMain, ImageFormat.Png);
    //}

    #endregion Test
}