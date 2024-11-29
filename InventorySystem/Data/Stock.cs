using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Data;

public class Stock
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int Quantity { get; set; }

    // Foreign keys
    public int ProductId { get; set; }
    public int SupplierId { get; set; }

    // Navigation properties
    public Product Product { get; set; }
    public Supplier Supplier { get; set; }

}