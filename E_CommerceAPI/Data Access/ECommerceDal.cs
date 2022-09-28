using E_CommerceAPI.Contexts;
using E_CommerceAPI.Data_Access;
using E_CommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI;

public class ECommerceDal : EFentityRepository<Product, ECommerceContext>, IECommerceDal
{
    public List<Product> GetProductsByCategory(string type)
    {
        using var context = new ECommerceContext();
        return context.Products.Where(p => p.ProductType == type).ToList();
    }

    public new Product? Add(Product product)
    {
        using var context = new ECommerceContext();
        var user = context.Users?.SingleOrDefault(user => user.Id == product.UserId);
        if (user == null)
        {
            return null;
        }

        context.Products?.Add(product);
        context.SaveChanges();
        return product;
    }
}