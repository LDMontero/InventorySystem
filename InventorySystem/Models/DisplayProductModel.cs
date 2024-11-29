using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models;

public class DisplayProductModel
{
    public int? Id { get; set; } = null;
    
    [Required]
    [MinLength(5, ErrorMessage = "Name must be at least 5 characters long.")]
    public string Name { get; set; }
    
    [Required]
    [Range(1, 1000000, ErrorMessage = "Quantity must be between 1 and 1000000.")]
    public int Quantity { get; set; }
    [Required]
    [Range(0.01, 1000000, ErrorMessage = "Price must be between 0.01 and 1000000.")]
    public decimal Price { get; set; }
    
}