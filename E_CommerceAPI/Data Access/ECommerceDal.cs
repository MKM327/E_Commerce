using E_CommerceAPI.Contexts;
using E_CommerceAPI.Data_Access;
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
}