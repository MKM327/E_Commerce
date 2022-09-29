using System.Linq.Expressions;
using E_CommerceAPI.Contexts;
using E_CommerceAPI.Models;

namespace E_CommerceAPI.Data_Access.Login_Data_Access;

public interface IEFLoginDal : IEFentityRepository<User>
{
    public User AddUser(User user);
    public User? VerifyUser(User user);
    public List<User>? GetAllUsers();
}