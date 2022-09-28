using System.ComponentModel.DataAnnotations;
using E_CommerceAPI.Models;

namespace TestAPI.Models;

public class Product:IEntity
{
    [Key]
    public int Id { get; set; }
    public string? ProductType { get; set; }
    public decimal Price { get; set; }
    public string? Header { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
}