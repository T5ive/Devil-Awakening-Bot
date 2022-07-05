namespace Devil_Awakening_Bot.Forms
{
    partial class FrmOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkSteamDota = new System.Windows.Forms.CheckBox();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.chkMain = new System.Windows.Forms.CheckBox();
            this.chkleave = new System.Windows.Forms.CheckBox();
            this.chkSetup = new System.Windows.Forms.CheckBox();
            this.chkPrepare = new System.Windows.Forms.CheckBox();
            this.chkTreasures = new System.Windows.Forms.CheckBox();
            this.chkSkill = new System.Windows.Forms.CheckBox();
            this.chkRoundEnd = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkBoss = new System.Windows.Forms.CheckBox();
            this.chkInGame = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGeneral = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Checked = true;
            this.chkAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoSave.Location = new System.Drawing.Point(6, 22);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(107, 19);
            this.chkAutoSave.TabIndex = 0;
            this.chkAutoSave.Text = "Auto Save Logs";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkSteamDota
            // 
            this.chkSteamDota.AutoSize = true;
            this.chkSteamDota.Checked = true;
            this.chkSteamDota.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSteamDota.Location = new System.Drawing.Point(6, 47);
            this.chkSteamDota.Name = "chkSteamDota";
            this.chkSteamDota.Size = new System.Drawing.Size(126, 19);
            this.chkSteamDota.TabIndex = 2;
            this.chkSteamDota.Text = "เปิด Steam && Dota2";
            this.chkSteamDota.UseVisualStyleBackColor = true;
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.Checked = true;
            this.chkBot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBot.Location = new System.Drawing.Point(6, 72);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(80, 19);
            this.chkBot.TabIndex = 3;
            this.chkBot.Text = "ขั้นตอนบอท";
            this.chkBot.UseVisualStyleBackColor = true;
            // 
            // chkMain
            // 
            this.chkMain.AutoSize = true;
            this.chkMain.Checked = true;
            this.chkMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMain.Location = new System.Drawing.Point(6, 97);
            this.chkMain.Name = "chkMain";
            this.chkMain.Size = new System.Drawing.Size(185, 19);
            this.chkMain.TabIndex = 4;
            this.chkMain.Text = "ขั้นตอน หน้าหลัก -> สร้างห้องสำเร็จ";
            this.chkMain.UseVisualStyleBackColor = true;
            // 
            // chkleave
            // 
            this.chkleave.AutoSize = true;
            this.chkleave.Checked = true;
            this.chkleave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkleave.Location = new System.Drawing.Point(6, 147);
            this.chkleave.Name = "chkleave";
            this.chkleave.Size = new System.Drawing.Size(117, 19);
            this.chkleave.TabIndex = 7;
            this.chkleave.Text = "ขั้นตอน ออกจากเกม";
            this.chkleave.UseVisualStyleBackColor = true;
            // 
            // chkSetup
            // 
            this.chkSetup.AutoSize = true;
            this.chkSetup.Checked = true;
            this.chkSetup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetup.Location = new System.Drawing.Point(177, 122);
            this.chkSetup.Name = "chkSetup";
            this.chkSetup.Size = new System.Drawing.Size(113, 19);
            this.chkSetup.TabIndex = 6;
            this.chkSetup.Text = "ขั้นตอน การ Setup";
            this.chkSetup.UseVisualStyleBackColor = true;
            // 
            // chkPrepare
            // 
            this.chkPrepare.AutoSize = true;
            this.chkPrepare.Checked = true;
            this.chkPrepare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrepare.Location = new System.Drawing.Point(6, 122);
            this.chkPrepare.Name = "chkPrepare";
            this.chkPrepare.Size = new System.Drawing.Size(155, 19);
            this.chkPrepare.TabIndex = 5;
            this.chkPrepare.Text = "ขั้นตอน เลือกด่าน -> เริ่มเกม";
            this.chkPrepare.UseVisualStyleBackColor = true;
            // 
            // chkTreasures
            // 
            this.chkTreasures.AutoSize = true;
            this.chkTreasures.Checked = true;
            this.chkTreasures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTreasures.Location = new System.Drawing.Point(177, 172);
            this.chkTreasures.Name = "chkTreasures";
            this.chkTreasures.Size = new System.Drawing.Size(109, 19);
            this.chkTreasures.TabIndex = 10;
            this.chkTreasures.Text = "ขั้นตอน เลือกกล่อง";
            this.chkTreasures.UseVisualStyleBackColor = true;
            // 
            // chkSkill
            // 
            this.chkSkill.AutoSize = true;
            this.chkSkill.Checked = true;
            this.chkSkill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkill.Location = new System.Drawing.Point(6, 172);
            this.chkSkill.Name = "chkSkill";
            this.chkSkill.Size = new System.Drawing.Size(104, 19);
            this.chkSkill.TabIndex = 9;
            this.chkSkill.Text = "ขั้นตอน เลือกสกิล";
            this.chkSkill.UseVisualStyleBackColor = true;
            // 
            // chkRoundEnd
            // 
            this.chkRoundEnd.AutoSize = true;
            this.chkRoundEnd.Checked = true;
            this.chkRoundEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoundEnd.Location = new System.Drawing.Point(177, 147);
            this.chkRoundEnd.Name = "chkRoundEnd";
            this.chkRoundEnd.Size = new System.Drawing.Size(94, 19);
            this.chkRoundEnd.TabIndex = 8;
            this.chkRoundEnd.Text = "ขั้นตอน จบรอบ";
            this.chkRoundEnd.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Checked = true;
            this.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdate.Location = new System.Drawing.Point(177, 47);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(89, 19);
            this.chkUpdate.TabIndex = 13;
            this.chkUpdate.Text = "พบการอัพเดท";
            this.chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkBoss
            // 
            this.chkBoss.AutoSize = true;
            this.chkBoss.Checked = true;
            this.chkBoss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoss.Location = new System.Drawing.Point(177, 197);
            this.chkBoss.Name = "chkBoss";
            this.chkBoss.Size = new System.Drawing.Size(101, 19);
            this.chkBoss.TabIndex = 12;
            this.chkBoss.Text = "ขั้นตอน ต่อสู้บอส";
            this.chkBoss.UseVisualStyleBackColor = true;
            // 
            // chkInGame
            // 
            this.chkInGame.AutoSize = true;
            this.chkInGame.Checked = true;
            this.chkInGame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInGame.Location = new System.Drawing.Point(6, 197);
            this.chkInGame.Name = "chkInGame";
            this.chkInGame.Size = new System.Drawing.Size(157, 19);
            this.chkInGame.TabIndex = 11;
            this.chkInGame.Text = "ขั้นตอน การคลิกในระหว่างเล่น";
            this.chkInGame.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGeneral);
            this.groupBox1.Controls.Add(this.chkAutoSave);
            this.groupBox1.Controls.Add(this.chkSteamDota);
            this.groupBox1.Controls.Add(this.chkUpdate);
            this.groupBox1.Controls.Add(this.chkBot);
            this.groupBox1.Controls.Add(this.chkBoss);
            this.groupBox1.Controls.Add(this.chkMain);
            this.groupBox1.Controls.Add(this.chkInGame);
            this.groupBox1.Controls.Add(this.chkPrepare);
            this.groupBox1.Controls.Add(this.chkTreasures);
            this.groupBox1.Controls.Add(this.chkSetup);
            this.groupBox1.Controls.Add(this.chkSkill);
            this.groupBox1.Controls.Add(this.chkleave);
            this.groupBox1.Controls.Add(this.chkRoundEnd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 230);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs Output";
            // 
            // chkGeneral
            // 
            this.chkGeneral.AutoSize = true;
            this.chkGeneral.Checked = true;
            this.chkGeneral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGeneral.Location = new System.Drawing.Point(177, 72);
            this.chkGeneral.Name = "chkGeneral";
            this.chkGeneral.Size = new System.Drawing.Size(88, 19);
            this.chkGeneral.TabIndex = 14;
            this.chkGeneral.Text = "แจ้งเตือนทั่วไป";
            this.chkGeneral.UseVisualStyleBackColor = true;
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox chkAutoSave;
        private Button btnSave;
        private CheckBox chkSteamDota;
        private CheckBox chkBot;
        private CheckBox chkMain;
        private CheckBox chkleave;
        private CheckBox chkSetup;
        private CheckBox chkPrepare;
        private CheckBox chkTreasures;
        private CheckBox chkSkill;
        private CheckBox chkRoundEnd;
        private CheckBox chkUpdate;
        private CheckBox chkBoss;
        private CheckBox chkInGame;
        private GroupBox groupBox1;
        private CheckBox chkGeneral;
    }
}