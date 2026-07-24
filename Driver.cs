
namespace Planner;

static class Driver
{
    [STAThread]
    static void Main()
    {
        MainWindow mainWindow = new MainWindow();
        Application.Run(mainWindow);
    
    }    
}