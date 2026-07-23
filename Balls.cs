namespace Planner;
using Information;
public class Balls
{
    public static void Main()
    {
        ScheduleBrick e = new ScheduleBrick("CSC 101", "02/04","Become Epstein");
        Console.WriteLine(e.ObtainInformation());
    }
}