using System.Diagnostics.Contracts;
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
    public User? VerifyUser(User user)
    {
        if (user == null)
            return null;

        using var context = new ECommerceContext();
        var userTable = context.Users?.Include("UserProfile").Include("Products");
        var DbUser = userTable?.SingleOrDefault(DBuser => DBuser.Username == user.Username);
        var password = DbUser?.Password;
        if (password == null || user.Password == null)
            return null;

        var verify = HashingManager.CheckPassword(user.Password, password);

        return verify ? DbUser : null;
    }



    public User AddUser(User user)
    {
        using var context = new ECommerceContext();
        user.Password = HashingManager.HashString(user.Password ?? "");
        context.Users?.Add(user);
        context.SaveChanges();
        return user;
    }

    public List<User>? GetAllUsers()
    {
        using var context = new ECommerceContext();
        var userList = context.Users?.Include("UserProfile").Include("Products").ToList();
        return userList;
    }

    public UserProfile? UpdateUserProfile(UserProfile profile)
    {
        using var context = new ECommerceContext();
        context.Entry(profile).State = EntityState.Modified;
        context.SaveChanges();
        return profile;
    }
    public UserProfile DeleteProfile(int id)
    {
        using var context = new ECommerceContext();
        var profile = context.UserProfiles.SingleOrDefault(profile => profile.Id == id);
        context.Entry(profile).State = EntityState.Deleted;
        context.SaveChanges();
        return profile;
    }
    public User UpdateUserPassword(int id)
    {
        throw new NotImplementedException();
    }
}
