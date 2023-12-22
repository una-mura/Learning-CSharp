namespace AccessControl;

public abstract class PhysicalSpace
{
    public string Label { get; }

    protected PhysicalSpace(string label)
    {
        Label = label;
    }
}