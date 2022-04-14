using System;
using System.Collections;

public class IUser
{
	public string Username;
	public string Password;
	public string Status;
	public bool isAdmin = false;
	public List<IUser> contacts = new List<IUser>();
	public IUser(string user, string pass, string stat)
	{
		Username = user;
		Password = pass;
		Status = stat;
	}
	public void AddRemContacts(IUser user)
    {
		Console.WriteLine("Would you like to add or remove a contact?")
		if(Console.ReadLine.toLowerCase == "add")
        {
			contacts.Add(user);
        }
		else if (Console.ReadLine.toLowerCase == "remove")
		{
			contacts.Remove(user);
		}
	}
}
