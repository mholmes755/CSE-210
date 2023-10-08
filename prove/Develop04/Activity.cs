public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public virtual string DisplayStartingMessage()
    {
        return "This is the base Activity Class Starting Message";
    }

    public virtual string DisplayEndingMessage()
    {
        return "This is the base Activity Class Ending Message";
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        foreach (string s in spinner)
        {
            Console.Write($"{s}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        }

    }

    public void ShowCountDown(int seconds)
    {
        
        
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}