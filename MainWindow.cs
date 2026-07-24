namespace Planner;

using System.Collections;
public class MainWindow : Form
{
    private List<Panel> panels = new List<Panel>();
    public MainWindow()
    {
        this.Text = "Hello!";
        this.WindowState = FormWindowState.Maximized;
        this.BackColor = Color.Black;
        this.AutoScroll = true;

        Button test = new Button();
        test.SetBounds(1300,1300,600,600);
        test.BackColor = Color.AliceBlue;

        

        //this.AutoScrollMinSize = new Size(9999,this.Height);
        CreateBrick();
        CreateBrick();
        CreateBrick();
        CreateBrick();
        
    }//u can only create 20 bricks l8er
    
    public void CreateBrick()
    {
        Panel newPanel = new Panel();
        Button myButton = new Button();

        newPanel.BackColor = Color.Red;
        myButton.BackColor = Color.AntiqueWhite;
        myButton.SetBounds(30,30,30,30);

        this.Controls.Add(newPanel);
        newPanel.Controls.Add(myButton);
        newPanel.SetBounds(30*(panels.Count()+1)+(290*panels.Count()), 30,250,250);

        this.Controls.Add(newPanel);
        panels.Add(newPanel);
    }
}//Panels later
