using System;

public interface UserDB
{
	public List<IUser> registered;
	public bool Login(string userID, string password)
    {
        foreach(IUser i in registered)
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
