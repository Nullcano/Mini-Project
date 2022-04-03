public class LinesIdleState
{
  private int linesIdle = 1;

  public int LinesIdle
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