public class LinesCurrentState
{
  private double linesCurrent = 0;

  public double LinesCurrent
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