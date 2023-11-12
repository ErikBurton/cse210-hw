using System;

class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times when you demonstrated strength")
    {

    }

    public override void Start()
    {
        base.Start();
        _ReflectOnExperiences();
    }

    private void _ReflectOnExperiences()
    {
        Random rand = new Random();

        for (int i = 0; i < duration;)
        {
            int randomPromptIndex = rand.Next(prompts.Length);
            Console.WriteLine(prompts[randomPromptIndex]);
            _ShowSpinner(3);

            Console.WriteLine("Reflect on this experience:");

            string[] questions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                _ShowSpinner(3);
            }

            i += 3 + (questions.Length * 3); // 3 seconds for each question and its spinner
        }
    }


}