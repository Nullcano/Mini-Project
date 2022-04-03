public class UpgradesState
{
  public class Upgrade
  {
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public int Effect { get; set; }
    public int Cost { get; set; }
    public int Level { get; set; }
  }

  public IEnumerable<Upgrade> upgrades = new[]
  {
    new Upgrade {
      Id = 1,
      Type = "Idle",
      Name = "Felincer",
      Description = "A feline freelancer that writes code for you.",
      Icon = "assets/felincer.png",
      Effect = 1,
      Cost = 8,
      Level = 0
    },
    new Upgrade {
      Id = 2,
      Type = "Click",
      Name = "Clawboard",
      Description = "A sturdy and claw-proof keyboard.",
      Icon = "assets/clawboard.png",
      Effect = 1,
      Cost = 32,
      Level = 0
    },
    new Upgrade {
      Id = 3,
      Type = "Idle",
      Name = "P.A.W.S.",
      Description = "“Program Automatically Without Scripting”",
      Icon = "assets/paws.png",
      Effect = 1,
      Cost = 128,
      Level = 0
    },
    new Upgrade {
      Id = 4,
      Type = "Click",
      Name = "Tabby",
      Description = "Intellisense to autocomplete code blocks.",
      Icon = "assets/tabby.png",
      Effect = 1,
      Cost = 512,
      Level = 0
    },
  };
}