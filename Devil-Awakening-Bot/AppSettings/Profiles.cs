namespace Devil_Awakening_Bot.AppSettings;

public class Profiles
{
    public string SteamPath { get; set; } = @"C:\Program Files (x86)\Steam";

    public int LimitRound { get; set; } = 5;

    public int PickTime { get; set; } = 30;

    public int NecroTime { get; set; } = 20;

    public int LeaveTime { get; set; } = 60 * 6;

    public bool UpSword { get; set; } = false;

    public int UpSwordTime { get; set; } = 35;

    [JsonConverter(typeof(StringEnumConverter))]
    public Episode Episode { get; set; } = Episode.EP2;

    [JsonConverter(typeof(StringEnumConverter))]
    public Level Level { get; set; } = Level.N20;

    public bool Abyss { get; set; } = true;

    public bool Ticket { get; set; } = true;

    public List<Artifact> Artifacts { get; set; } = new();

    //public List<string> Heroes { get; set; } = new();

    public List<Hero> Heroes { get; set; } = new();

    public bool VIP { get; set; } = false;

    public bool Refresh { get; set; } = false;

    public List<Talent> Talents { get; set; } = new();

    public List<string> Treasures { get; set; } = new();

    public bool Gift { get; set; } = false;

    public List<Skill> Skills { get; set; } = new();

    public AwakingSpell AwakingSpell { get; set; } = AwakingSpell.None;

    public List<Necromancy> Necromancy { get; set; } = new();
}