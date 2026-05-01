

namespace JZJ.Accounts;

internal class Registration
{
    public string Name { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string FullName { get => $"{Name} {LastName}"; }

    public decimal Balance { get; set; } = 0;

    public string Password { get; set; } = string.Empty;

    public void ShowInfo()
    {
        Console.WriteLine($"saxeli da gavri: {FullName}");
        Console.WriteLine($"balansis raodenoba: {Balance}");
        Console.WriteLine($"paroli: {Password}");
    }
}
