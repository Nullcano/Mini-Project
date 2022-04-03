public class CatState
{
  public string UpdateCatSprite()
  {
    var random = new Random();
    var sprites = new List<string>{ "assets/paws-idle.gif", "assets/paws-left-down.gif", "assets/paws-right-down.gif" };
    int index = random.Next(sprites.Count);
    return sprites[index];
  }
}