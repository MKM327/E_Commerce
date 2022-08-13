using E_CommerceAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI;

public class ECommerceDAL
{
    private ECommerceDAL() { }
    private static ECommerceDAL _instance;


    public static ECommerceDAL GetInstance()
    {
        return _instance;
    }
    public List<Product> GetAllProducts()
    {
        using var context = new ECommerceContext();
        return context.Products.ToList();
    }

    public Product AddProduct(Product product)
    {
        using var context = new ECommerceContext();
         context.Products.Add(product);
         context.SaveChanges();
         return product;
    }

    public Product UpdateProduct(Product updatedProduct)
    {
        using var context = new ECommerceContext();
        context.Entry(updatedProduct).State  =EntityState.Modified;
        context.SaveChanges();
        return updatedProduct;
    }
    public Product DeleteProduct(Product product)
    {
        using var context = new ECommerceContext();
        context.Entry(product).State = EntityState.Deleted;
        context.SaveChanges();
        return product;
    }
    public Product GetProductById(int id)
    {
        using var context = new ECommerceContext();
        return context.Products.SingleOrDefault(product => product.Id == id);
    }
}