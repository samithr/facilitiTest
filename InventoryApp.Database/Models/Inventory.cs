namespace InventoryApp.Database.Models
{
    public class Inventory
    {
        public const int NameMaxLength = ModelConstants.NameMaxLength;
        public const int DescriptionMaxLength = ModelConstants.DescriptionMaxLength;
        public const int UnitsMaxLenght = ModelConstants.AvailableUnitMaxLength;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AvailableUnits { get; set; }
        public int ReOrderLevel { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
