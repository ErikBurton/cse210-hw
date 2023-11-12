using System;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.")
    {
    }

    public override void Start()
    {
        base.Start();
        _PerformBreathingExercise();
    }

    private void _PerformBreathingExercise()
    {
        Console.WriteLine("Breathe in...");
        _ShowSpinner(duration / 2);
        Console.WriteLine("Breathe out...");
        _ShowSpinner(duration / 2);
    }
}