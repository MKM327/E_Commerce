using System.ComponentModel.DataAnnotations;

namespace TestAPI.Models;

public interface IEntity
{
    [Key]
    public int Id { get; set; }
}