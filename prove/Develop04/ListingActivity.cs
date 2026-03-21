class ListingActivity : Activity
{
     public ListingActivity(): base("Listing",  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    

    public override void Run()

    {
        standardStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_userSessionDuration);
        Console.WriteLine("Get Ready...");
        showCountSession(3);
    }

}
