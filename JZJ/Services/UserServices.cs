using JZJ.Accounts;
using JZJ.Contacts;
using System.Data;

namespace JZJ.Services;

internal class UserServices : IUserServices
{
    private List<User> users;


    public UserServices()
    {
        users = new List<User>(); 
    }

    //properthy: logedq in user

    //implement interface

    public void Login(string username, string password)
    {
       //if user exist, currentUser = user  
    }  

    public void Logout()
    {
        //Current becomes null 

    }

    public Guid Register(User user)
    {
        foreach (var item in users)
        {if (user.Email == item.Email)
                throw new ArgumentException("user exist!"); 
        }

        //trow if exist
        users.Add(user);
        return user.Id;
    }

}
