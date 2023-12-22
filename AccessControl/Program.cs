using AccessControl;

PhysicalSpace[] spacesList =
{
    new PublicSpace("University"),
    new WorkerSpace("IT Secretary"),
    new AdminSpace("Academic Coordination")
};

User[] usersList =
{
    new Admin(0, "Vanessa"),
    new Worker(1, "Helena"),
    new Visitor(2, "Carolina")
};

List<Log> accessLog = new();

foreach (var space in spacesList)
{
    foreach (var user in usersList)
    {
        if (user.Access(space))
        {
            accessLog.Add(new Log(user, space));
            Console.WriteLine("Access Granted");
        }
        
        else
        {
            Console.WriteLine("Access denied");    
        }
    }
}