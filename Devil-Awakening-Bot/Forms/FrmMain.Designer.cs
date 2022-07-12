namespace Devil_Awakening_Bot.Forms
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.registerBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.bossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.tmCount = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbForceClose = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbBoss = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbRound = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPick = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbBotStep = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbWave = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNecro = new System.Windows.Forms.Label();
            this.tmUI = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnEndRound = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Location = new System.Drawing.Point(0, 308);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.devToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(154, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.toolStripSeparator3,
            this.profileToolStripMenuItem,
            this.toolStripSeparator4,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.registerBotToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.topMostToolStripMenuItem.Text = "Top Most";
            this.topMostToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topMostToolStripMenuItem_CheckedChanged);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.CheckOnClick = true;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.logsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(134, 6);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(134, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // registerBotToolStripMenuItem
            // 
            this.registerBotToolStripMenuItem.Name = "registerBotToolStripMenuItem";
            this.registerBotToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.registerBotToolStripMenuItem.Text = "Register Bot";
            this.registerBotToolStripMenuItem.Click += new System.EventHandler(this.registerBotToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.heroToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.bossToolStripMenuItem});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.devToolStripMenuItem.Text = "Dev";
            this.devToolStripMenuItem.Visible = false;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // heroToolStripMenuItem
            // 
            this.heroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.heroToolStripMenuItem.Name = "heroToolStripMenuItem";
            this.heroToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.heroToolStripMenuItem.Text = "Hero";
            this.heroToolStripMenuItem.Click += new System.EventHandler(this.heroToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Bounty Hunter",
            "Bristleback",
            "Centaur Warrior",
            "Crystal Maiden",
            "Death Prophet",
            "Drow Ranger",
            "Gyrocopter",
            "Huskar",
            "Juggernaut",
            "Legion Commander",
            "Lina",
            "Lone Druid",
            "Magnus",
            "Medusa",
            "Morphling",
            "Naga Siren",
            "Nevermore",
            "Omniknight",
            "Phantom Assassin",
            "Phantom Lancer",
            "Skywrath Mage",
            "Snapfire",
            "Sniper",
            "Sven",
            "Tidehunter",
            "Troll Warlord",
            "Undying",
            "Void Spirit",
            "Zeus"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.stepToolStripMenuItem.Text = "Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "Arcade = 0",
            "Library = 1",
            "Devil = 2",
            "Lobby = 3",
            "Setting = 4",
            "Start = 5",
            "Accept = 6",
            "Level = 7",
            "SelectPath = 8",
            "Hero = 9",
            "Select = 10",
            "Apply = 11",
            "Ready = 12",
            "Talent = 13",
            "Artifact = 14",
            "Setup = 15",
            "InGame = 16"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            // 
            // bossToolStripMenuItem
            // 
            this.bossToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.bossToolStripMenuItem.Name = "bossToolStripMenuItem";
            this.bossToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.bossToolStripMenuItem.Text = "Boss";
            this.bossToolStripMenuItem.Click += new System.EventHandler(this.bossToolStripMenuItem_Click);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
            // 
            // tmCount
            // 
            this.tmCount.Interval = 1000;
            this.tmCount.Tick += new System.EventHandler(this.tmCount_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สถิติ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTotal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbWin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbForceClose, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbBoss, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbRound, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 106);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "รอบทั้งหมด:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(91, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(54, 21);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "0/0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ชนะ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWin
            // 
            this.lbWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWin.Location = new System.Drawing.Point(91, 21);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(54, 21);
            this.lbWin.TabIndex = 3;
            this.lbWin.Text = "0";
            this.lbWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "บังคับปิด:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbForceClose
            // 
            this.lbForceClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbForceClose.Location = new System.Drawing.Point(91, 42);
            this.lbForceClose.Name = "lbForceClose";
            this.lbForceClose.Size = new System.Drawing.Size(54, 21);
            this.lbForceClose.TabIndex = 11;
            this.lbForceClose.Text = "0";
            this.lbForceClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "บอสที่ฆ่า:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBoss
            // 
            this.lbBoss.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBoss.Location = new System.Drawing.Point(91, 63);
            this.lbBoss.Name = "lbBoss";
            this.lbBoss.Size = new System.Drawing.Size(54, 21);
            this.lbBoss.TabIndex = 10;
            this.lbBoss.Text = "0";
            this.lbBoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "รอบที่:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRound
            // 
            this.lbRound.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRound.Location = new System.Drawing.Point(91, 84);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(54, 21);
            this.lbRound.TabIndex = 9;
            this.lbRound.Text = "0/5";
            this.lbRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "ปิด:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "เก็บของ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPick
            // 
            this.lbPick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPick.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPick.Location = new System.Drawing.Point(62, 42);
            this.lbPick.Name = "lbPick";
            this.lbPick.Size = new System.Drawing.Size(83, 21);
            this.lbPick.TabIndex = 13;
            this.lbPick.Text = "00:30 นาที";
            this.lbPick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbExit
            // 
            this.lbExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbExit.Location = new System.Drawing.Point(62, 84);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(83, 21);
            this.lbExit.TabIndex = 15;
            this.lbExit.Text = "05:30 นาที";
            this.lbExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ภายในรอบ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbBotStep, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbWave, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbPick, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbNecro, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbExit, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(148, 105);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "ขั้นตอน:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBotStep
            // 
            this.lbBotStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBotStep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBotStep.Location = new System.Drawing.Point(62, 0);
            this.lbBotStep.Name = "lbBotStep";
            this.lbBotStep.Size = new System.Drawing.Size(83, 21);
            this.lbBotStep.TabIndex = 1;
            this.lbBotStep.Text = "Wait";
            this.lbBotStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(3, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 21);
            this.label17.TabIndex = 2;
            this.label17.Text = "บอส:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWave
            // 
            this.lbWave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWave.Location = new System.Drawing.Point(62, 21);
            this.lbWave.Name = "lbWave";
            this.lbWave.Size = new System.Drawing.Size(83, 21);
            this.lbWave.TabIndex = 3;
            this.lbWave.Text = "0";
            this.lbWave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Necro:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNecro
            // 
            this.lbNecro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNecro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNecro.Location = new System.Drawing.Point(62, 63);
            this.lbNecro.Name = "lbNecro";
            this.lbNecro.Size = new System.Drawing.Size(83, 21);
            this.lbNecro.TabIndex = 17;
            this.lbNecro.Text = "00:30 นาที";
            this.lbNecro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmUI
            // 
            this.tmUI.Enabled = true;
            this.tmUI.Tick += new System.EventHandler(this.tmUI_Tick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.Controls.Add(this.btnResume, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEndRound, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 279);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(154, 29);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // btnResume
            // 
            this.btnResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResume.Enabled = false;
            this.btnResume.Location = new System.Drawing.Point(3, 3);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(63, 23);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "Pause";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnEndRound
            // 
            this.btnEndRound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEndRound.Enabled = false;
            this.btnEndRound.Location = new System.Drawing.Point(72, 3);
            this.btnEndRound.Name = "btnEndRound";
            this.btnEndRound.Size = new System.Drawing.Size(79, 23);
            this.btnEndRound.TabIndex = 1;
            this.btnEndRound.Text = "End Round";
            this.btnEndRound.UseVisualStyleBackColor = true;
            this.btnEndRound.Click += new System.EventHandler(this.btnEndRound_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Devil Awakening Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private System.Windows.Forms.Timer tmCount;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem devToolStripMenuItem;
        internal ToolStripMenuItem logsToolStripMenuItem;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label lbForceClose;
        private Label label9;
        private Label lbBoss;
        private Label label11;
        private Label lbRound;
        private Label label1;
        private Label lbTotal;
        private Label label3;
        private Label lbWin;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label13;
        private Label lbBotStep;
        private Label label17;
        private Label lbWave;
        private System.Windows.Forms.Timer tmUI;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem topMostToolStripMenuItem;
        private Label label6;
        private Label label2;
        private Label lbPick;
        private Label lbExit;
        private Label label4;
        private Label lbNecro;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnResume;
        private Button btnEndRound;
        private ToolStripMenuItem heroToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem stepToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripMenuItem bossToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem registerBotToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}