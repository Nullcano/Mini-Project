public class LinesIdleState
{
  private double linesIdle = 1;

  public double LinesIdle
  {
    get => linesIdle;
    set
    {
      linesIdle = value;
      NotifyStateChanged();
    }
  }

  public event Action? OnChange;

  private void NotifyStateChanged() => OnChange?.Invoke();
}