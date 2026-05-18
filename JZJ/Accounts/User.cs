

namespace JZJ.Accounts;

internal class User
{
    public Guid Id { get; set; }

    public string Email { get; set; }

    public string Name { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string FullName { get => $"{Name} {LastName}"; }

    public decimal Balance { get; set; } = 0;

    public string Password { get; set; } = string.Empty;

    public User() { }

    public User(string name, string lastName, string fullName, decimal balance, string password, string email) {

        this.Name = name;
        this.LastName = lastName;
        this.Balance = balance;
        this.Id = Guid.NewGuid();
        this.Password = password;
        this.Email = email;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"saxeli da gavri: {FullName}");
        Console.WriteLine($"balansis raodenoba: {Balance}");
        Console.WriteLine($"paroli: {Password}");
    }
}
