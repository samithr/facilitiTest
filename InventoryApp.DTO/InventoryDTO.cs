using System.ComponentModel.DataAnnotations;

namespace InventoryApp.DTO
{
    public class InventoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Description is Required")]

        [Range(0, 100, ErrorMessage = "Available Units should not contain characters and value should not exceed 99")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
        public int? AvailableUnits { get; set; }

        [Range(0, 100, ErrorMessage = "Re Order Level should not contain characters and value should not exceed 99")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a number.")]
        public int? ReOrderLevel { get; set; }

        [Required(ErrorMessage = "Unit Price is Required")]
        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Must be a decimal number.")]
        [Range(0, 9999999999999999.99)]
        public decimal? UnitPrice { get; set; }
    }
}
