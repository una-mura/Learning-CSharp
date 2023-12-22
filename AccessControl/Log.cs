namespace AccessControl;

public class Log
{
    public Log(User userLog, PhysicalSpace spaceLog)
    {
        UserLog = userLog;
        SpaceLog = spaceLog;
    }
    
    public User UserLog { get; }
    public PhysicalSpace SpaceLog { get; }
}