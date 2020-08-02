namespace InventoryApp.Database.Models
{
    public class ReOrderLevel
    {
        public const int NameMaxLength = ModelConstants.NameMaxLength;
        public const int DescriptionMaxLength = ModelConstants.NameMaxLength;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
