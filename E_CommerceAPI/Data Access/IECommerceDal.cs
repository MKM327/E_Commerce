﻿using E_CommerceAPI.Data_Access;
using E_CommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Models;

namespace TestAPI;

public interface IECommerceDal : IEFentityRepository<Product>
{
    public List<Product>? GetProductsByCategory(string type);
    public new Product? Add(Product product);
    public List<Product>? GetUserProducts(int id);
}