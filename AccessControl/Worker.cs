namespace AccessControl;

public class Worker : User
{
    public Worker(int id, string name) : base(id, name)
    {
        Role = GetType().Name;
    }

    public override bool Access(PhysicalSpace space) => space.GetType() != typeof(AdminSpace);
}