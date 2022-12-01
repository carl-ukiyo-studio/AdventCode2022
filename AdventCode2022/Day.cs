namespace AdventCode2022;

public abstract class Day : IDay
{
    public abstract int Calculate(string input);
    public abstract int Index { get; }
}