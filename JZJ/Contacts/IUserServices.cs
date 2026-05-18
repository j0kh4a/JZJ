

using JZJ.Accounts;

namespace JZJ.Contacts;

internal interface IUserServices
{
    Guid Register(User user);

    void Login(string username, string password);
    
    void Logout();
}
