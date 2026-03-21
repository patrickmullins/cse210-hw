class testActivity : Activity
{
    public testActivity() : base("testing is awesome title", "this is a test activity discription lets find out if this actually prints in the description field")
    {

    }
    public override void Run()
    {
        standardStartMessage();
        countingDown();
        showCountSession();
        standardEndMessage();
        Console.ReadKey();

    }
}