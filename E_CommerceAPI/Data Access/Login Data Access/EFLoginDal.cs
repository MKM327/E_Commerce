using System.Linq.Expressions;
using System.Security.Cryptography;
using E_CommerceAPI.Contexts;
using E_CommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI;

namespace E_CommerceAPI.Data_Access.Login_Data_Access;

public class EFLoginDal : EFentityRepository<User, ECommerceContext>, IEFLoginDal
{
    public void AddUser()
    {

    }
    public User? VerifyUser(User user)
    {
        using var context = new ECommerceContext();
        var DbUser = context.Users?.SingleOrDefault(DBuser => DBuser.Username == user.Username);
        var password = DbUser?.Password;
        if (password == null)
        {
            return null;
        }
        var verify = HashingManager.CheckPassword(user.Password, password);
        return verify ? DbUser : null;
    }

    public User AddUser(User user)
    {
        using var context = new ECommerceContext();
        user.Password = HashingManager.HashString(user.Password);
        context.Users?.Add(user);
        context.SaveChanges();
        return user;
    }
}