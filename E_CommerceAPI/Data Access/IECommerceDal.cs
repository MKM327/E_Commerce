using E_CommerceAPI.Data_Access;
using TestAPI.Models;

namespace TestAPI;

public interface IECommerceDal : IEFentityRepository<Product>
{
    public List<Product> GetProductsByCategory(string type);
}