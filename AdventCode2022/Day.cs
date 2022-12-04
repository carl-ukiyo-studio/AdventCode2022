namespace AdventCode2022;

public abstract class Day : IDay
{
    public abstract int Ex1(StreamReader input);
    public abstract int Ex2(StreamReader input);
    public virtual string Test(string i, string j)
    {
        throw new NotImplementedException();
    }

    public abstract int Index { get; }
}