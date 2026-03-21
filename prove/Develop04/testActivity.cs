class testActivity : Activity
{
    public testActivity() : base("test", "this is a test activity.")
    {

    }
    public override void Run()
    {
        standardStartMessage();
        countingDown();
        showCountSession();
        standardEndMessage();
    }
}