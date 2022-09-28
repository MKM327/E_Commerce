using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestAPI.Models;

namespace E_CommerceAPI.Models;

public class Product:IEntity
{
    [Key]
    public int Id { get; set; }
    public string? ProductType { get; set; }
    public decimal Price { get; set; }
    public string? Header { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    [ForeignKey("Users")]
    public int UserId { get; set; }
}