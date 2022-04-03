public class LinesClickState
{
  private double linesClick = 1;

  public double LinesClick
  {
    get => linesClick;
    set
    {
      linesClick = value;
      NotifyStateChanged();
    }
  }

  public event Action? OnChange;

  private void NotifyStateChanged() => OnChange?.Invoke();
}