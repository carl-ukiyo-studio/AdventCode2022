namespace AdventCode2022;

public abstract class Day : IDay
{
    public int Index = 0;
    public abstract int Calculate(string input);
}