using System;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.")
    {
    }

    public override void Start()
    {
        base.Start();
        PerformBreathingExercise();
    }

    private void PerformBreathingExercise()
    {
        Console.WriteLine("Breathe in...");
        ShowSpinner(duration / 2);
        Console.WriteLine("Breathe out...");
        ShowSpinner(duration / 2);
    }
}