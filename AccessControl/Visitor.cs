namespace AccessControl;

public class Visitor : User
{
    public Visitor(int id, string name) : base(id, name)
    {
        Role = GetType().Name;
    }

    public override bool Access(PhysicalSpace space) => space.GetType() == typeof(PublicSpace);
}