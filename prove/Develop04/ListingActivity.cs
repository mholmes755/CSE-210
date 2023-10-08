public class ListingActvity : Activity
{
    protected int _count;
    protected List<string> _prompts;


    public ListingActvity()
    {
        _prompts = new List<string>
        {
            "When was a time that you smiled this week?",
            "How many times did you do something right? Even when it was little?",
            "When have you felt the Holy Ghost this week?",
            "When have you felt loved this week?",
            "List your strengths."
        };
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int randomIndex = _random.Next(0, _prompts.Count);
        return _prompts[randomIndex]; 
    }


// Get Starting and Ending Messages for Listing Activity
    public override string DisplayStartingMessage()
    {
        return "This is the Listing Activity. This activity is designed to help you reflect on the many good things in your life by having you list as many things as you can based on a prompt that will be given. ";
    }

        public override string DisplayEndingMessage()
    {
        return "Well done! You've completed the Listing Activity. See how many good things are in your life? It's god to remember that you always have positive things going for you. ";
    }

}