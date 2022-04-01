using Fluxor;

[FeatureState]
public class PlayerStates
{
  public string PlayerName { get; set; } = "Unknown Feline";
  static string PlayerIcon { get; set; } = "default-icon";
  public string IconURL { get; private set; } = $"assets/{PlayerIcon}.png";
}
