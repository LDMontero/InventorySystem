using InventorySystem.Data;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Services;

public class ProductService
{
    ApplicationDbContext _context;
    
    public ProductService(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task<Product[]> GetProductsAsync() => _context.Products.ToArrayAsync();
    
    // add product
    public async Task AddProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }
    
    // update product
    public async Task UpdateProductAsync(Product product)
    {
        var existingProduct = await _context.Products.FindAsync(product.Id);
        if (existingProduct != null)
        {
            _context.Entry(existingProduct).State = EntityState.Detached;
        }

        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
    
    // delete product
    public async Task DeleteProductAsync(int productId)
    {
        var product = await _context.Products.FindAsync(productId);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}