namespace Devil_Awakening_Bot.Utils;

public static class Img
{
    private static readonly string AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
    private static readonly string SteamPath = Path.Combine(AppPath, "Dota2\\Steam");
    private static readonly string MainPath = Path.Combine(AppPath, "Dota2\\Main");
    private static readonly string DevilPath = Path.Combine(AppPath, "Dota2\\Devil");
    public static readonly string LevelPath = Path.Combine(AppPath, "Dota2\\Level");
    public static readonly string HeroPath = Path.Combine(AppPath, "Dota2\\Hero");
    public static readonly string TalentPath = Path.Combine(AppPath, "Dota2\\Talent");
    public static readonly string ArtifactPath = Path.Combine(AppPath, "Dota2\\Artifact");
    public static readonly string SpellPath = Path.Combine(AppPath, "Dota2\\Spell");
    public static readonly string SpellActivePath = Path.Combine(AppPath, "Dota2\\Spell\\Active");
    public static readonly string SkillPath = Path.Combine(AppPath, "Dota2\\Skill");
    public static readonly string TreasuresPath = Path.Combine(AppPath, "Dota2\\Treasures");

    public static readonly string

    #region Steam

        PlayDota = Path.Combine(SteamPath, "playDota.png"),

        ForcePlay = Path.Combine(SteamPath, "forcePlay.png"),

    #endregion

    #region Main
        /// <summary>   ปุ่ม X ตอนเปิดเกม. </summary>
        LeaveEvents = Path.Combine(MainPath, "LeaveEvents.png"),

        /// <summary>   อาร์เคต. </summary>
        Arcade = Path.Combine(MainPath, "arcade.png"),

        /// <summary>   อาร์เคต เรืองแสง. </summary>
        Arcade2 = Path.Combine(MainPath, "arcade2.png"),

        /// <summary>   คัลง. </summary>
        Library = Path.Combine(MainPath, "library.png"),

        /// <summary>   devil. </summary>
        Devil = Path.Combine(MainPath, "devil.png"),

        /// <summary>   สร้างล็อบบี้กำหนดเอง. </summary>
        Lobby = Path.Combine(MainPath, "lobby.png"),

        /// <summary>   สร้าง. </summary>
        Create = Path.Combine(MainPath, "create.png"),

        /// <summary>   เริ่มเกม. </summary>
        Start = Path.Combine(MainPath, "start.png"),

        /// <summary>   ยอมรับ. </summary>
        Accept = Path.Combine(MainPath, "accept.png"),

        /// <summary>   ตัดการเชื่อมต่อ. </summary>
        Disconnect = Path.Combine(MainPath, "disconnect.png"),

        /// <summary>   ออกจากเกม. </summary>
        Leave = Path.Combine(MainPath, "leave.png"),

        /// <summary>   ใช่ ออกจากเกม. </summary>
        Leave2 = Path.Combine(MainPath, "leave2.png"),

        /// <summary>   พบการอัพเดท. </summary>
        Update = Path.Combine(MainPath, "update.png"),

        /// <summary>   เชื่อมต่ออีกครั้ง. </summary>
        Reconnect = Path.Combine(MainPath, "Reconnect.png"),

    #endregion Main

    #region Devil

        /// <summary>   เลือกฮีโร่. </summary>
        Select = Path.Combine(DevilPath, "select.png"),

        /// <summary>   ยืนยันเลือกฮีโร่. </summary>
        Apply = Path.Combine(DevilPath, "apply.png"),

        /// <summary>   รีเฟรชหาฮีโร่. </summary>
        Refresh = Path.Combine(DevilPath, "refresh.png"),

        /// <summary>   ช่อง Talent. </summary>
        Talent = Path.Combine(DevilPath, "talent.png"),

        /// <summary>   Sword หมายเลข 1 (ซ้ายล่าง) </summary>
        Sword1 = Path.Combine(DevilPath, "1.png"),

        /// <summary>   Armor หมายเลข 2 (ซ้ายล่าง) </summary>
        Armor2 = Path.Combine(DevilPath, "2.png"),

        /// <summary>   Armor เกราะแดง</summary>
        ArmorRed = Path.Combine(DevilPath, "armor.png"),

        /// <summary>   Armor เกราะแดง</summary>
        ArmorRed2 = Path.Combine(DevilPath, "armor2.png"),

        /// <summary>   Armor เกราะแดง</summary>
        ArmorRed3 = Path.Combine(DevilPath, "armor3.png"),

        /// <summary>   Armor เกราะแดง</summary>
        ArmorRed4 = Path.Combine(DevilPath, "armor4.png"),

        /// <summary>   Treasures หมายเลข 4 (ซ้ายล่าง) </summary>
        Treasures4 = Path.Combine(DevilPath, "4.png"),

        /// <summary>   ปุ่ม X หน้า Treasures. </summary>
        TreasuresLeave = Path.Combine(DevilPath, "treasuresLeave.png"),

        /// <summary>   Random Event หมายเลข 5 (ซ้ายล่าง) </summary>
        Event5 = Path.Combine(DevilPath, "5.png"),

        Q = Path.Combine(DevilPath, "Q.png"),
        W = Path.Combine(DevilPath, "W.png"),
        E = Path.Combine(DevilPath, "E.png"),
        R = Path.Combine(DevilPath, "R.png"),

        /// <summary>   Alt+1 ขวาล่าง ไว้เช็คว่าอยู่หน้าจอหรือไม่. </summary>
        Alt1 = Path.Combine(DevilPath, "alt1.png"),

        /// <summary>   Devil ขวาบน ไว้เช็คว่าเจอบอสหรือไม่. </summary>
        BossEP1 = Path.Combine(DevilPath, "bossEp1.png"),

        /// <summary>   หัวกระโหลกชื่อบอส </summary>
        BossEP2 = Path.Combine(DevilPath, "bossEp2.png"),

        /// <summary>   หลังฆ่าบอสเสร็จ รับไอเท็ม OK. </summary>
        BossOk = Path.Combine(DevilPath, "ok.png"),

        /// <summary>   หลังฆ่าบอสครบ 4 ตัว จะเจอบอสตัวที่ 5. </summary>
        Go = Path.Combine(DevilPath, "go.png"),

        /// <summary>   Ticket ขวาบนหลังจบเกม. </summary>
        TicketPlus = Path.Combine(DevilPath, "ticket plus.png"),

        /// <summary>   Ticket ขวาบนหลังจบเกม. </summary>
        TicketEnd = Path.Combine(DevilPath, "ticket end.png"),

        /// <summary>   ออกปุ่มเล็ก. </summary>
        Exit = Path.Combine(DevilPath, "exit.png"),

        /// <summary>   ออกปุ่มใหญ่. </summary>
        Exit2 = Path.Combine(DevilPath, "exit2.png")

    #endregion Devil

    ;
}