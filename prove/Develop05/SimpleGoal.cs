internal class SimpleGoal : Goal
{
    public new string Name { get; set; }
    public new int Score { get; set; }

    public override string GetDescription()
    {
        throw new NotImplementedException();
    }
}