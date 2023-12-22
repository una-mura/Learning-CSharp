namespace AccessControl;

public class Admin : User
{
    public Admin(int id, string name) : base(id, name)
    {
        Role = GetType().Name;
    }
}