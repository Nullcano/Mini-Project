public class LinesClickState
{
  private int linesClick = 1;

  public int LinesClick
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