namespace MiniProject.Models
{
    public class Upgrade
    {
        public int UId { get; set; }
        public string? UType { get; set; }
        public string? UName { get; set; }
        public string? UDescription { get; set; }
        public string? UIcon { get; set; }
        public int UEffect { get; set; }
        public int UCost { get; set; }
    }
}