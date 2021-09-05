using System.ComponentModel.DataAnnotations;

namespace LikDemo.Models
{
    public class Line
    {
        [Required]
        [Display(Name = "Unit net price")]
        public int? UnitNetPrice { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int? Quantity { get; set; }
        public int? VatRate { get; set; }
        public int? DiscountType { get; set; }
        public int? DiscountValue { get; set; }
    }
}
