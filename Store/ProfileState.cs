public class ProfileState
{
  public string? Playername { get; set; } = "Unknown Feline";
  public int Level { get; set; } = 1;
  public int Experience { get; set; }
  public int ExperienceToNextLevel { get; set; }
  public string? PlayerIcon { get; set; } = "../assets/default-icon.gif";
}