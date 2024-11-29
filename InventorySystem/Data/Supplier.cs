using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Data;

public class Supplier
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    // Navigation properties
    public ICollection<Product> Products { get; set; }
    public ICollection<Category> Categories { get; set; }
    public ICollection<Brand> Brands { get; set; }
    public ICollection<Stock> Stocks { get; set; }
}