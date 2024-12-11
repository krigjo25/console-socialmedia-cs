namespace SocialmediaApp.lib;

public class DataCollection
{
    // Initializing class members
    
    // Initializing Properties
    public readonly List<User> Users = [];

    // Initializing Methods
    internal void InitializePeople()
    {
        //  name, email, birthday, isAdmin = false
        Users.Add(new User("Tina S. Holley", "TinaSHolley@armyspy.com", "12/06/1970"));
        Users.Add(new User("Sharon L. Conwell", "SharonLConwell@dayrep.com", "05/24/1953"));
        Users.Add(new User("Naomi D. Salas", "NaomiDSalas@teleworm.us", "12/25/1962"));
    }
    protected void PushUser(User obj)
    {
        Users.Add(obj);
    }

    public void SimulateAddFriend(User obj)
    {

        //  Simulate AddFriend
        foreach (var friend in Users)
        {
            // Ensure that the object is not itself.
            if(friend != obj && !obj.Friends.Contains(friend))
            {
                obj.AddFriend(friend);
                friend.AddFriend(obj);
            }
            
        }
    }
    public void SimulateRemoveFriend(User obj)
    {
        //  Simulate RemoveFriend
        foreach (var friend in Users)
        {
            // Ensure that the object is not itself.
            if(friend != obj)
            {
                obj.RemoveFriend(friend);
                friend.RemoveFriend(obj);
            }
            
        }
    }

    public void PrintUserInfo(User obj )
    {
        Console.WriteLine("Initializing People");
        var listofFriends = ListFriends(obj);
        Console.WriteLine("***********************************************\n");
        Console.WriteLine($"Name: {obj.Name}, Friends :{listofFriends}");
        Console.WriteLine("***********************************************\n");
        
    }

    private string ListFriends(User obj)
    {
        string listofFriends = "";
        foreach (var friend in obj.Friends)
        {
            listofFriends += friend.Name + ", ";
            
        }
        return listofFriends;
    }
}