using TestAPI.Models;

namespace E_CommerceAPI.Models;

public class UserProfile:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }

}