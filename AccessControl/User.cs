namespace AccessControl;

public abstract class User
{
    public int IdNumber { get; }
    public string Name { get; }
    protected string? Role { get; set; }

    protected User(int id, string name)
    {
        Name = name;
        IdNumber = id;
    }

    public virtual bool Access(PhysicalSpace space) => true;
}