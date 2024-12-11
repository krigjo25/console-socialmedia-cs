// See https://aka.ms/new-console-template for more information

using System.Text;
using SocialmediaApp.lib;

class ConsoleApp
{
    public static void Main(string[] args)
    {
        // Initialize the project
        var db = new DataCollection();

        db.InitializePeople();
        
        // Run the program
        foreach (var obj in db.Users)
        {
           db.SimulateAddFriend(obj); 
            db.PrintUserInfo(obj);

        }
        foreach (var obj in db.Users)
        {
            db.SimulateRemoveFriend(obj); 
            db.PrintUserInfo(obj);
        }
        
        //RunApp();
    }
}