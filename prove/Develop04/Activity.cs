using System;

abstract class Activity
{
    protected string StartMessage;
    protected string StartDuration;
    protected string EndMessage;

    public abstract void Run();
}