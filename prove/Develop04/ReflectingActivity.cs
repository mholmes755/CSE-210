public class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectingActivity()
    {
        _prompts = new List<string>
        {
            "Think of a time when somebody thanked you for doing them a service.",
            "What was the hardest thing you've done this week?",
            "How many hours have you put into homework or your job? Both?",
            "How many things did you get done yesterday?",
            "When was a time you felt really capable?",
            "Think of a time when you percervered through a tough situation. "
        };

        _questions = new List<string>
        {
            "What made it worth doing?",
            "Why were you in that situation to begin with?",
            "How do you feel about it?",
            "If given the chance, would you go back and change how it went?",
            "What can you learn from this?"
        };
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random _random = new Random();
        int randomIndex = _random.Next(_questions.Count);
        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"--- {randomPrompt} ---");
    }

    public void DisplayQuestion()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine($"--- {randomQuestion} ---");
    }

// Get Starting and Ending Messages for Reflecting Activity
    public override string DisplayStartingMessage()
    {
        return "This is the Reflecting Activity. This activity is designed to show you how strong and capable you are. You will be given a prompt to think about to show you the power you have in both your own life and and the lives of those in your life.";
    }

        public override string DisplayEndingMessage()
    {
        return "Remembering that we are strong and could handle situations that we've been in gives us reassurance and hope that we can handle more situations that will come our way.";
    }

}

