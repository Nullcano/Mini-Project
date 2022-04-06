public class UpgradesState
{
  public class Upgrade
  {
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public double Effect { get; set; }
    public double Cost { get; set; }
    public int Level { get; set; }
  }

  public List<Upgrade> Upgrades = new List<Upgrade>
  {
    new Upgrade {
      Id = 1,
      Type = "Click",
      Name = "Clawboard",
      Description = "A sturdy and claw-proof keyboard to handle more typing.",
      Icon = "assets/clawboard.gif",
      Effect = 1,
      Cost = 8,
      Level = 0
    },
    new Upgrade {
      Id = 2,
      Type = "Idle",
      Name = "Felincer",
      Description = "A feline freelancer that writes code for you.",
      Icon = "assets/felincer.gif",
      Effect = 1,
      Cost = 128,
      Level = 0
    },
    new Upgrade {
      Id = 3,
      Type = "Click",
      Name = "Tabby",
      Description = "Intellisense extension to autocomplete code blocks.",
      Icon = "assets/tabby.gif",
      Effect = 64,
      Cost = 512,
      Level = 0
    },
    new Upgrade {
      Id = 4,
      Type = "Idle",
      Name = "P.A.W.S.",
      Description = "Extension to \"Program Automatically Without Scripting\".",
      Icon = "assets/paws.gif",
      Effect = 16,
      Cost = 2048,
      Level = 0
    },
  };
}