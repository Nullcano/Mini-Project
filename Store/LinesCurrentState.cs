public class LinesCurrentState
{
  private int linesCurrent = 0;

  public int LinesCurrent
  {
    get => linesCurrent;
    set
    {
      linesCurrent = value;
      NotifyStateChanged();
    }
  }

  public event Action? OnChange;

  private void NotifyStateChanged() => OnChange?.Invoke();
}