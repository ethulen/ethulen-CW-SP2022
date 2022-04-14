using System;

public class IUDB: UserDB
{
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
}
