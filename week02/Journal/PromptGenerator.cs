using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who pushed me hardest to compete today?",
        "What was the highlight play of my day?",
        "What obstacle did I fight through today?",
        "What moment got my adrenaline pumping today?",
        "What am I thankful for in today' training?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}