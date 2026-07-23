namespace Planner.Information;

public class ScheduleBrick
{
    private string className;
    private string dueDate;
    private string assignmentName;
    public ScheduleBrick(string className,string dueDate,string assignmentName)
    {
        this.className = className;
        this.dueDate = dueDate;
        this.assignmentName = assignmentName;
    }

    public string ObtainInformation()
    {
        return "Class: " + className + "\nDue Date: " + dueDate + "\nAssignment: " + assignmentName;
    }


}