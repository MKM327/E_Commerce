using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using TestAPI.Models;

namespace E_CommerceAPI.Models
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public UserProfile UserProfile { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
