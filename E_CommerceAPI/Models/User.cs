using System.ComponentModel.DataAnnotations;
using TestAPI.Models;

namespace E_CommerceAPI.Models
{
    public class User:IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
