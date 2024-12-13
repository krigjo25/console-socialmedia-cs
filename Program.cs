// See https://aka.ms/new-console-template for more information

using SocialmediaApp.lib;

namespace SocialmediaApp;

internal static class ConsoleApp
{
    public static void Main(string[] args)
    {
        // Initializing the list
        List<User> users = [];
        
        // Initializing the community
        InitializePeople(users);
            
        // Run the program
        RunApp(users);
    }
    private static void InitializePeople(List<User> users)
    {
        //  name, email, birthday, isAdmin = false
        users.Add(new User("Tina S. Holley", "TinaSHolley@armyspy.com", "12/06/1970"));
        users.Add(new User("Sharon L. Conwell", "SharonLConwell@dayrep.com", "05/24/1953"));
        users.Add(new User("Naomi D. Salas", "NaomiDSalas@teleworm.us", "12/25/1962"));
    }

    private static void SimulateAddFriend(User obj, List<User> users)
    {
        foreach (var friend in users)
        {
            if (friend != obj && !friend.Equals(obj) && !friend.Friends.Contains(obj))
            {
                obj.AddFriend(friend);
                friend.AddFriend(obj);
            }
        }
    }

    private static void SimulateRemoveFriend(User obj, List<User> users)
    {
        //  Simulate RemoveFriend
        foreach (var friend in users)
        {
            // Ensure that the object is not itself.
            if(!friend.Equals(obj))
            {
                obj.RemoveFriend(friend);
                friend.RemoveFriend(obj);
            }
            
        }
    }

    private static void PrintUserInfo(User obj)
    {
        var listofFriends = ListFriends(obj.Friends);
        Console.WriteLine("***********************************************\n");
        Console.WriteLine($"Name: {obj.Name}, Friends :\n{listofFriends}");
        Console.WriteLine("***********************************************\n");
    }

    private static string ListFriends(List<User> friends)
    {
        string listofFriends = "";
        foreach (var friend in friends)
        {
            listofFriends += friend.Name + ", ";
            
        }
        return listofFriends;
    }

    private static void RunApp(List<User> users)
    {
        foreach (var obj in users)
        {
            SimulateAddFriend(obj, users); 
            PrintUserInfo(obj);
        }
        foreach (var obj2 in users)
        {
            SimulateRemoveFriend(obj2, users); 
            PrintUserInfo(obj2);
        }
    }
}