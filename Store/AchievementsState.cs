public class AchievementsState
{
  public class Achievement
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public double Reward { get; set; }
    public bool Unlocked { get; set; }
    public bool Claimed { get; set; }
  }

  public List<Achievement> Achievements = new List<Achievement>
  {
    new Achievement {
      Id = 1,
      Name = "Stainless Steel",
      Description = "Reach Clawboard level 10.",
      Icon = "../assets/achievements/stainless-steel.gif",
      Reward = 1024,
      Unlocked = false,
      Claimed = false
    },
    new Achievement {
      Id = 2,
      Name = "Small Startup",
      Description = "Reach Felincer level 10.",
      Icon = "../assets/achievements/small-startup.gif",
      Reward = 1024,
      Unlocked = false,
      Claimed = false
    },
    new Achievement {
      Id = 3,
      Name = "Tabby Plus",
      Description = "Reach Tabby level 10.",
      Icon = "../assets/achievements/tabby-plus.gif",
      Reward = 2048,
      Unlocked = false,
      Claimed = false
    },
    new Achievement {
      Id = 4,
      Name = "Artificial Intellisense",
      Description = "Reach P.A.W.S. level 10.",
      Icon = "../assets/achievements/artificial-intellisense.gif",
      Reward = 2048,
      Unlocked = false,
      Claimed = false
    },
  };
}