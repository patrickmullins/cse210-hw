class PromptGenerator
{
    //initializing the list with a string data type to hold the random prompts for the journal program when called by the main program.
    List<string> randomPrompt = new List<string>()
    {"Describe my most meaningful relationship and what makes it special.", "How do I want people to feel after spending time with me?", "What brought me joy today, no matter how small?", "What would I do if I knew I couldn’t fail?", "Complete this sentence: People can count on me for _____. Give two real examples.", "Think of a tough experience that now helps you help others. What did it teach you?", "How did I see the hand of the Lord in my life today?", "If I had one thing I could do over today, what would it be?"};
    // initialized a randomGenerator using the built in C# random number generator
    Random randomGenerator = new Random();
    public string GetRandomPrompt()
    {
        // random number generator from 0 to however many entries are stored within the randomPrompt list that was created above.
        int randomIndex = randomGenerator.Next(0, randomPrompt.Count);
        //returns the random question from the list of questions stored in the randomPrompt Variable.
        return randomPrompt[randomIndex];
    }
}