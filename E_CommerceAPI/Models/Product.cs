using System.ComponentModel.DataAnnotations;

namespace TestAPI.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string? ProductType { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
}