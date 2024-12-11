namespace SocialmediaApp.lib;

public class User : DataCollection
{
    // Initializing class members
    private string _name;
    private string _email;
    private bool _isAdmin;
    private string _birthday;
    
    // Initializing properties
    public string Name;
    public string Email;
    public bool IsAdmin;
    public string Birthday;
    
    // Initializing friend list
    public readonly List<User> Friends = [];
    
    // Initializing Constructor
    public User(string name, string email, string birthday, bool isAdmin = false)
    {
        Name = name;
        Email = email;
        IsAdmin = isAdmin;
        Birthday = birthday;
    }
    
    // Initializing the methods
    public void AddFriend(User obj)
    {
        Friends.Add(obj);
    }
    
    public void RemoveFriend(User obj)
    {
        Friends.Remove(obj);
    }

    
}