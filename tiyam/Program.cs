// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

var users = new List<User>
{
    new()
    {
        Id = 1,
        Name = "mohammad javad"
    },
    new()
    {
        Id = 2,
        Name = "tiyam"
    }
};

start:
{
    Console.Clear();
    Console.WriteLine("############# Menu #########");
    Console.WriteLine("1- Add");
    Console.WriteLine("2- List");
    Console.WriteLine("3- Update");
    Console.WriteLine("4- Delete");
    Console.WriteLine("5- User Count");
    Console.WriteLine("0- Exit");
    Console.Write("Please enter your choice: ");

    var input = Console.ReadLine();

    if (input != null)
    {
        Console.Clear();

        var selectedMenu = int.Parse(input);

        switch (selectedMenu)
        {
            case 1:
            {
                Console.Write("Give Me Name: ");
                var name = Console.ReadLine();
                if (name != null)
                {
                    users.Add(new User { Id = users.Count + 1, Name = name });
                }

                Console.WriteLine($"Your name added to list");
                break;
            }
            case 2:
                foreach (var user in users)
                {
                    Console.WriteLine("User Id: " + user.Id);
                    Console.WriteLine($"User Name: {user.Name}");
                    Console.WriteLine("-------------------------");
                }

                break;
            case 3:
                Console.Write("Give Me YourName that you want to change: ");
                var Yourname = Console.ReadLine();
                Console.Write("Give Me Your NewName: ");
                var newname = Console.ReadLine();
       
                
                       foreach (var user in users)
                       {
                           if (Yourname == user.Name)
                           {
                               user.Name = newname;
                           }
                       }
       
                break;
            case 4:
                Console.Write("Give Me YourName that you want to delete: ");
                var deletename = Console.ReadLine();
               /* foreach (var user in users)
                {
                    if (deletename == user.Name)
                    {
                       var delete= users.ToDictionary(x => x.Id).FirstOrDefault();
                       users.Remove(delete);
                    }
                     }
*/
                    

                break;
            
            case 5:
                Console.WriteLine("the count:" +users.Count);
                
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Out Of Range");
                break;
        }
    }
}

Console.WriteLine("Please press enter fot return to main manu");
Console.ReadLine();
goto start;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
