using System;

public class UserDBProxy
{
	public UserDB RealDatabase = new UserDB();
    public bool Login(string userID, string password)
    {
        foreach (IUser i in registered)
        {
            if (i.Username.Equals(userID) && i.Password.Equals(password))
            {
                return true;
            }
        }
        return false;
    }
    public void Logout(IUser user)
    {
        user.Status = "Logged out";
    }
}
