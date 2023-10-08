using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {

    }


// Get Starting and Ending Messages for Breathing Activity
    public override string DisplayStartingMessage()
    {
        return "This is the Breathing Activity. This activity is designed to help you relax by walking you through breathing in and out slowly. Now clear your mind and focus on your breathing.";
    }

// Write Out Ending Message
    public override string DisplayEndingMessage()
    {
        return "Focusing on our breathing is important because it forces us to block out other distractions and soley give oxygen to our body, which it needs to function. This can help clear our thoughts and relax the body.";
    }

    public void Run()
    {

    }
}